﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEtGeneric
{
    internal class Liste<T> : IEnumerable<T>
    {
        //une liste d'éléments non typés (type object)
        private ArrayList elements;
        public int Count => elements.Count;
        public T this[int index] => (T)elements[index];
        public Liste()
        {
            elements = new ArrayList();
        }
        public void Ajouter(T element)
        {
            elements.Add(element);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in elements)
            {
                yield return (T)item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
