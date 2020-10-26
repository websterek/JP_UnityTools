using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JPool<T> : MonoBehaviour where T : MonoBehaviour, IJPool
{
    public T prefab;
    public int size;

    public enum StartMode { Awake, Start, Manual }
    public StartMode startMode;

    public enum EndMode { Extend, Loop, Null }
    public EndMode endMode;


    private Queue<T> poolQueue;
    private int poolAvaliable;


    #region Initialisation
    private void Awake()
    {
        if (startMode == StartMode.Awake)
        {
            InitializePool(true);
        }
    }

    private void Start()
    {
        if (startMode == StartMode.Start)
        {
            InitializePool(true);
        }
    }
    #endregion


    #region Public Operations
    public void InitializePool(bool forced = false)
    {
        if (startMode == StartMode.Manual || forced)
        {
            poolQueue = new Queue<T>(size);

            for (int i = 0; i < size; i++)
            {
                InstantiatePrefab();
            }

            poolAvaliable = size;
        }
    }

    public T GetObject()
    {
        T pooledObj;

        if (poolAvaliable == 0)
        {
            switch (endMode)
            {
                case EndMode.Extend:
                    pooledObj = InstantiatePrefab();
                    break;

                case EndMode.Loop: //TODO: repair this shiet
                    pooledObj = null;
                    break;

                default:
                    pooledObj = null;
                    break;
            }
        }
        else
        {
            poolAvaliable--;
            pooledObj = poolQueue.Dequeue();
            poolQueue.Enqueue(pooledObj);
        }

        return pooledObj;
    }

    public T GetObject(Transform parent, bool active = true)
    {
        T pooledObj = GetObject();

        pooledObj.transform.parent = parent;
        pooledObj.gameObject.SetActive(active);

        return pooledObj;
    }

    public T GetObject(Vector3 position, Quaternion rotation, Transform parent, bool active = true)
    {
        T pooledObj = GetObject();

        pooledObj.transform.position = position;
        pooledObj.transform.rotation = rotation;
        pooledObj.transform.parent = parent;
        pooledObj.gameObject.SetActive(active);

        return pooledObj;
    }

    public void ReturnObject(T pooledObj, bool removeParent = true)
    {
        poolAvaliable++;

        if (removeParent) pooledObj.transform.parent = transform;
        pooledObj.OnReturnObject();
        pooledObj.gameObject.SetActive(false);
    }

    public void ReturnAllObjects()
    {
        foreach (T pooledObj in poolQueue)
        {
            if (pooledObj.gameObject.activeSelf) ReturnObject(pooledObj);
        }
    }
    #endregion


    #region Private Operations
    private void ResetTransform(T pooledObj)
    {
        pooledObj.transform.position = Vector3.zero;
        pooledObj.transform.rotation = Quaternion.identity;
    }

    private T InstantiatePrefab()
    {
        T pooledObj = Instantiate(prefab, transform);
        pooledObj.gameObject.SetActive(false);
        poolQueue.Enqueue(pooledObj);

        return pooledObj;
    }
    #endregion
}

public interface IJPool
{
    void OnGetObject();
    void OnReturnObject();
}