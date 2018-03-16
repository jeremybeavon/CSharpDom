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

        public override IReadOnlyCollection<TExtensionMethod> ExtensionMethods => WrappedObject.ExtensionMethods;

        protected override IReadOnlyCollection<TMethod> Methods => WrappedObject;
    }
}