using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class ImmutableAttributeArgumentListWrapper :
        IChildSyntaxList<AttributeSyntax, AttributeArgumentSyntax>
    {
        private readonly Func<SeparatedSyntaxList<AttributeArgumentSyntax>> getList;
        private readonly Action<SeparatedSyntaxList<AttributeArgumentSyntax>> setList;
        private readonly Func<AttributeArgumentSyntax, bool> filter;

        public ImmutableAttributeArgumentListWrapper(
            Func<SeparatedSyntaxList<AttributeArgumentSyntax>> getList,
            Action<SeparatedSyntaxList<AttributeArgumentSyntax>> setList,
            bool isNamed)
        {
            this.getList = getList;
            this.setList = setList;
            filter = isNamed ?
                new Func<AttributeArgumentSyntax, bool>(syntax => syntax.NameEquals != null) :
                new Func<AttributeArgumentSyntax, bool>(syntax => syntax.NameEquals == null);
        }

        public AttributeArgumentSyntax this[int index]
        {
            get { return getList().Where(filter).ElementAt(index); }
            set { setList(getList().Replace(this[index], value)); }
        }

        public int Count
        {
            get { return getList().Count(filter); }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(AttributeArgumentSyntax item)
        {
            setList(getList().Add(item));
        }

        public void Clear()
        {
            throw new NotSupportedException();
        }

        public bool Contains(AttributeArgumentSyntax item)
        {
            return getList().Contains(item);
        }

        public void CopyTo(AttributeArgumentSyntax[] array, int arrayIndex)
        {
            throw new NotSupportedException();
        }

        public IEnumerator<AttributeArgumentSyntax> GetEnumerator()
        {
            return ((IEnumerable<AttributeArgumentSyntax>)getList()).Where(filter).GetEnumerator();
        }

        public int IndexOf(AttributeArgumentSyntax item)
        {
            return getList().Where(filter).ToList().IndexOf(item);
        }

        public void Insert(int index, AttributeArgumentSyntax item)
        {
            setList(getList().Insert(index, item));
        }

        public bool Remove(AttributeArgumentSyntax item)
        {
            setList(getList().Remove(item));
            return true;
        }

        public void RemoveAt(int index)
        {
            setList(getList().RemoveAt(index));
        }

        public AttributeSyntax Set(int index, AttributeArgumentSyntax value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
