using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JP
{
    [Serializable]
    public class JDictionary<K, V> : IDictionary<K, V>, ISerializationCallbackReceiver
    {
        [SerializeField]
        List<KeyValuePairSer> list = new List<KeyValuePairSer>();

        [SerializeField]
        Dictionary<K, V> dict = new Dictionary<K, V>();

        [HideInInspector]
        public string error = null;

        #region     KeyValuePairSer struct
        [Serializable]
        public struct KeyValuePairSer
        {
            public K Key;
            public V Value;

            public KeyValuePairSer(K key, V value)
            {
                Key = key;
                Value = value;
            }
        }
        #endregion

        #region     ISerializationCallbackReceiver
        public void OnBeforeSerialize()
        {
            foreach (KeyValuePair<K, V> pairDict in dict)
            {
                KeyValuePairSer pairList = new KeyValuePairSer(pairDict.Key, pairDict.Value);
                if (list.Contains(pairList) == false)
                {
                    list.Add(pairList);
                }
            }
        }

        public void OnAfterDeserialize()
        {
            dict.Clear();

            try
            {
                foreach (KeyValuePairSer pairList in list)
                {
                    dict.Add(pairList.Key, pairList.Value);
                }
            }
            catch (Exception e)
            {
                error = e.ToString();
            }
        }
        #endregion

        #region     IDictionary<TKey, TValue>
        public V this[K key]
        {
            get => dict[key];
            set => dict[key] = value;
        }

        public ICollection<K> Keys => dict.Keys;

        public ICollection<V> Values => dict.Values;

        public int Count => dict.Count;

        public bool IsReadOnly => false;

        public void Add(K key, V value)
        {
            dict.Add(key, value);
        }

        public void Add(KeyValuePair<K, V> item)
        {
            dict.Add(item.Key, item.Value);
        }

        public void Clear()
        {
            dict.Clear();
        }

        public bool Contains(KeyValuePair<K, V> item)
        {
            return dict.ContainsKey(item.Key) && dict.ContainsValue(item.Value);
        }

        public bool ContainsKey(K key)
        {
            return dict.ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<K, V>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            return dict.GetEnumerator();
        }


        public bool Remove(K key)
        {
            return dict.Remove(key);
        }

        public bool Remove(KeyValuePair<K, V> item)
        {
            if (Contains(item))
            {
                return dict.Remove(item.Key);
            }
            else
            {
                return false;
            }
        }

        public bool TryGetValue(K key, out V value)
        {
            return dict.TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return dict.GetEnumerator();
        }
        #endregion
    }
}
