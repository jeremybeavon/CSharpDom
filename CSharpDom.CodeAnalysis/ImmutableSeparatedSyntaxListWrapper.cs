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
        private readonly Func<SeparatedSyntaxList<TSyntax>> getList;
        private readonly Action<SeparatedSyntaxList<TSyntax>> setList;

        public ImmutableSeparatedSyntaxListWrapper(
            Func<SeparatedSyntaxList<TSyntax>> getList,
            Action<SeparatedSyntaxList<TSyntax>> setList)
        {
            this.getList = getList;
            this.setList = setList;
        }

        public TSyntax this[int index]
        {
            get { return getList()[index]; }
            set { setList(getList().Replace(this[index], value)); }
        }

        public int Count
        {
            get { return getList().Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(TSyntax item)
        {
            setList(getList().Add(item));
        }

        public void Clear()
        {
            throw new NotSupportedException();
        }

        public bool Contains(TSyntax item)
        {
            return getList().Contains(item);
        }

        public void CopyTo(TSyntax[] array, int arrayIndex)
        {
            throw new NotSupportedException();
        }

        public IEnumerator<TSyntax> GetEnumerator()
        {
            return ((IEnumerable<TSyntax>)getList()).GetEnumerator();
        }

        public int IndexOf(TSyntax item)
        {
            return getList().IndexOf(item);
        }

        public void Insert(int index, TSyntax item)
        {
            setList(getList().Insert(index, item));
        }

        public bool Remove(TSyntax item)
        {
            setList(getList().Remove(item));
            return true;
        }

        public void RemoveAt(int index)
        {
            setList(getList().RemoveAt(index));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
