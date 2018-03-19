using CSharpDom.Common;
using CSharpDom.Common.Editable;
using CSharpDom.Common.Editable.Partial;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableNestedStructCollectionWrapper<TStruct, TPartialStruct> :
        EditableNestedStructCollection<TStruct, TPartialStruct>,
        IWrapper<IEditableNestedStructCollection<TStruct, TPartialStruct>>
        where TStruct : IEditableNestedStruct
        where TPartialStruct : IEditableNestedPartialStruct
    {
        public EditableNestedStructCollectionWrapper(IEditableNestedStructCollection<TStruct, TPartialStruct> structCollection)
        {
            WrappedObject = structCollection;
        }

        public override ICollection<TPartialStruct> PartialStructs
        {
            get { return WrappedObject.PartialStructs; }
            set { WrappedObject.PartialStructs = value; }
        }

        public override ICollection<TStruct> Structs
        {
            get { return WrappedObject; }
            set { throw new NotImplementedException(); }
        }

        public IEditableNestedStructCollection<TStruct, TPartialStruct> WrappedObject { get; private set; }
    }
}