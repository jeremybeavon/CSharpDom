using System;
using System.Collections;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Partial;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractStructCollection<TStruct, TPartialStruct> :
        AbstractGenericVisitableObject,
        IStructCollection<TStruct, TPartialStruct>
        where TStruct : IStruct
        where TPartialStruct : IPartialStruct
    {
        public int Count
        {
            get { return PartialStructs.Count + Structs.Count; }
        }

        public abstract IReadOnlyCollection<TPartialStruct> PartialStructs { get; }

        protected abstract IReadOnlyCollection<TStruct> Structs { get; }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitStructCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitStructCollectionChildren(this, visitor);
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
