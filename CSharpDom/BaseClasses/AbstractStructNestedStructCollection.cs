using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructNestedStructCollection<TStruct, TPartialStruct> :
        IStructNestedStructCollection<TStruct, TPartialStruct>
        where TStruct : IStructNestedStruct
        where TPartialStruct : IPartialStruct
    {
        public int Count
        {
            get { return PartialStructs.Count + Structs.Count; }
        }

        public abstract IReadOnlyCollection<TPartialStruct> PartialStructs { get; }

        protected abstract IReadOnlyCollection<TStruct> Structs { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructNestedStructCollection(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructNestedStructCollectionChildren(this, visitor);
        }

        public IEnumerator<TStruct> GetEnumerator()
        {
            return Structs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
