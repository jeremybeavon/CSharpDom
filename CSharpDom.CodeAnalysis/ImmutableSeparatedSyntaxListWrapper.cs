using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class ImmutableSeparatedSyntaxListWrapper<TSyntax> : IList<TSyntax>
        where TSyntax : SyntaxNode
    {
        private readonly IHasChild<SeparatedSyntaxList<TSyntax>> parent;

        public ImmutableSeparatedSyntaxListWrapper(IHasChild<SeparatedSyntaxList<TSyntax>> parent)
        {
            this.parent = parent;
        }

        public TSyntax this[int index]
        {
            get { return parent.Child[index]; }
            set { parent.Child.Replace(this[index], value); }
        }

        public int Count
        {
            get { return parent.Child.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(TSyntax item)
        {
            parent.Child = parent.Child.Add(item);
        }

        public void Clear()
        {
            throw new NotSupportedException();
        }

        public bool Contains(TSyntax item)
        {
            return parent.Child.Contains(item);
        }

        public void CopyTo(TSyntax[] array, int arrayIndex)
        {
            throw new NotSupportedException();
        }

        public IEnumerator<TSyntax> GetEnumerator()
        {
            return ((IEnumerable<TSyntax>)parent.Child).GetEnumerator();
        }

        public int IndexOf(TSyntax item)
        {
            return parent.Child.IndexOf(item);
        }

        public void Insert(int index, TSyntax item)
        {
            parent.Child = parent.Child.Insert(index, item);
        }

        public bool Remove(TSyntax item)
        {
            parent.Child = parent.Child.Remove(item);
            return true;
        }

        public void RemoveAt(int index)
        {
            parent.Child = parent.Child.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
