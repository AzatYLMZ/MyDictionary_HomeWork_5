using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T_k, T_v>
    {
        T_k[] _key;
        T_k[] _tempKey;
        T_v[] _value;
        T_v[] _tempValue;

        public MyDictionary()
        {
            _key = new T_k[0];
            _value = new T_v[0];
        }
        public void Add(T_k item1, T_v item2)
        {
            _tempKey = _key;
            _key = new T_k[_key.Length + 1];
            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
            }
            _key[_key.Length - 1] = item1;

            _tempValue = _value;
            _value = new T_v[_value.Length + 1];
            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
            }
            _value[_value.Length - 1] = item2;
        }
        public int Count
        {
            get { return _key.Length + _value.Length; }
        }
        public void Yazdir()
        {
            Console.WriteLine("Öğrenciler\n");
            for (int i = 0; i < _key.Length; i++)
            {
                Console.WriteLine("  " + _key[i] + ": " + _value[i]);
            }
        }

    }
}