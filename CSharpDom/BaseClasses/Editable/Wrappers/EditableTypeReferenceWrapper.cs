using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableTypeReferenceWrapper : EditableTypeReference, IWrapper<IEditableTypeReference>
    {
        public EditableTypeReferenceWrapper(IEditableTypeReference typeReference)
        {
            WrappedObject = typeReference;
        }

        public IEditableTypeReference WrappedObject { get; private set; }
    }
}