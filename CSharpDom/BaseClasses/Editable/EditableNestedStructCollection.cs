﻿using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.Common.Partial;
using CSharpDom.Wrappers.Internal;
using System.Collections;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable
{
    public abstract class EditableNestedStructCollection<TStruct, TPartialStruct> :
        AbstractGenericVisitableObject,
        INestedStructCollection<TStruct, TPartialStruct>
        where TStruct : INestedStruct
        where TPartialStruct : INestedPartialStruct
    {
        public int Count
        {
            get { return PartialStructs.Count + Structs.Count; }
        }

        public abstract ICollection<TPartialStruct> PartialStructs { get; set; }

        public abstract ICollection<TStruct> Structs { get; set; }

        IReadOnlyCollection<TPartialStruct> IHasPartialStructs<TPartialStruct>.PartialStructs
        {
            get { return new ReadOnlyCollectionWrapper<TPartialStruct>(PartialStructs); }
        }

        public override void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNestedStructCollection(this);
        }

        public override void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNestedStructCollectionChildren(this, visitor);
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
