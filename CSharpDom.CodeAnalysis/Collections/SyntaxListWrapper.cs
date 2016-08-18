using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class SyntaxListWrapper<T, TSyntax> : IList<T>
        where T : IHasSyntax<TSyntax>
        where TSyntax : SyntaxNode
    {
        private readonly IReplaceSyntaxList<TSyntax> parent;
        private readonly Func<SyntaxList<TSyntax>> list;
        private readonly Func<TSyntax, T> converter;

        public SyntaxListWrapper(IReplaceSyntaxList<TSyntax> parent, Func<SyntaxList<TSyntax>> list, Func<TSyntax, T> converter)
        {
            this.parent = parent;
            this.list = list;
            this.converter = converter;
        }

        public int Count
        {
            get { return list().Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public T this[int index]
        {
            get { return converter(list()[index]); }
            set
            {
                SyntaxList<TSyntax> currentList = list();
                parent.ReplaceSyntaxList(currentList.Replace(currentList[index], value.Syntax));
            }
        }

        public void Add(T item)
        {
            parent.ReplaceSyntaxList(list().Add(item.Syntax));
        }

        public void Clear()
        {
            SyntaxList<TSyntax> currentList = list();
            while (currentList.Count != 0)
            {
                currentList = currentList.RemoveAt(0);
            }

            parent.ReplaceSyntaxList(currentList);
        }

        public bool Contains(T item)
        {
            return list().IndexOf(item.Syntax) != -1;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            SyntaxList<TSyntax> currentList = list();
            for (int index = 0; index < currentList.Count && arrayIndex < array.Length; index++, arrayIndex++)
            {
                array[arrayIndex] = converter(currentList[arrayIndex]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list().Select(converter).GetEnumerator();
        }

        public bool Remove(T item)
        {
            parent.ReplaceSyntaxList(list().Remove(item.Syntax));
            return true;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return list().IndexOf(item.Syntax);
        }

        public void Insert(int index, T item)
        {
            parent.ReplaceSyntaxList(list().Insert(index, item.Syntax));
        }

        public void RemoveAt(int index)
        {
            parent.ReplaceSyntaxList(list().RemoveAt(index));
        }
    }
}
