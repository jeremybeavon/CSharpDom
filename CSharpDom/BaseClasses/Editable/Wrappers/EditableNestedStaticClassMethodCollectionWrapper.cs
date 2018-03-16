using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableNestedStaticClassMethodCollectionWrapper<TMethod> :
        EditableNestedStaticClassMethodCollection<TMethod>,
        IWrapper<IEditableNestedStaticClassMethodCollection<TMethod>>
        where TMethod : IEditableStaticClassMethod
    {
        public EditableNestedStaticClassMethodCollectionWrapper(IEditableNestedStaticClassMethodCollection<TMethod> methods)
        {
            WrappedObject = methods;
        }

        public IEditableNestedStaticClassMethodCollection<TMethod> WrappedObject { get; private set; }

        protected override IReadOnlyCollection<TMethod> Methods => WrappedObject;
    }
}