using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableStaticClassMethodCollectionWrapper<TMethod, TExtensionMethod> :
        EditableStaticClassMethodCollection<TMethod, TExtensionMethod>,
        IWrapper<IEditableStaticClassMethodCollection<TMethod, TExtensionMethod>>
        where TMethod : IEditableStaticClassMethod
        where TExtensionMethod : IEditableExtensionMethod
    {
        public EditableStaticClassMethodCollectionWrapper(IEditableStaticClassMethodCollection<TMethod, TExtensionMethod> methods)
        {
            WrappedObject = methods;
        }

        public IEditableStaticClassMethodCollection<TMethod, TExtensionMethod> WrappedObject { get; private set; }

        public override ICollection<TExtensionMethod> ExtensionMethods
        {
            get => WrappedObject.ExtensionMethods;
            set => WrappedObject.ExtensionMethods = value;
        }

        public override ICollection<TMethod> Methods
        {
            get => WrappedObject;
            set => throw new NotImplementedException();
        }
    }
}