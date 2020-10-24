using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class JPool<T> : MonoBehaviour where T : MonoBehaviour
{
    public T prefab;
    public int size;

    private Queue<T> poolQueue;
    private int poolAvaliable;

    public enum EndMode { Extend, Loop, Null }
    public EndMode endMode;

    public enum StartMode { Awake, Start, Manual }
    public StartMode startMode;

    private void Awake()
    {
        if (startMode == StartMode.Awake)
        {
            InitializePool();
        }
    }

    private void Start()
    {
        if (startMode == StartMode.Start)
        {
            InitializePool();
        }
    }

    #region Pool Initializations
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

    private T InstantiatePrefab()
    {
        T pooledObj = Instantiate(prefab, transform);
        pooledObj.gameObject.SetActive(false);
        poolQueue.Enqueue(pooledObj);

        return pooledObj;
    }
    #endregion

    #region Pool Operations
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

                case EndMode.Loop:
                    pooledObj = poolQueue.Dequeue();
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

    public void ReturnObject(T pooledObj)
    {
        poolAvaliable++;

        pooledObj.transform.parent = transform;
        pooledObj.gameObject.SetActive(false);
    }
    #endregion
}
