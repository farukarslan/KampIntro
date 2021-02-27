using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] _kArray;
        TValue[] _vArray;
        public MyDictionary()
        {
            _kArray = new TKey[0];
            _vArray = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] _kTempArray = _kArray;
            TValue[] _vTempArray = _vArray;
            _kArray = new TKey[_kArray.Length + 1];
            _vArray = new TValue[_vArray.Length + 1];

            for (int i = 0; i < _kTempArray.Length; i++)
            {
                _kArray[i] = _kTempArray[i];
                _vArray[i] = _vTempArray[i];
            }
            _kArray[_kArray.Length - 1] = key;
            _vArray[_vArray.Length - 1] = value;
        }
        public void List()
        {
            for (int j = 0; j < _kArray.Length; j++)
            {
                Console.WriteLine("Ürün adı : " + _kArray[j] + ", " + "Stok adedi : " + _vArray[j]);
            }
        }
        public int Length
        {
            get { return _vArray.Length; }
        }
    }
}
