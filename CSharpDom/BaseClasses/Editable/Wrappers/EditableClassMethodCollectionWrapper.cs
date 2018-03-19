using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableClassMethodCollectionWrapper<TMethod, TExplicitInterfaceMethod> :
        EditableClassMethodCollection<TMethod, TExplicitInterfaceMethod>,
        IWrapper<IEditableClassMethodCollection<TMethod, TExplicitInterfaceMethod>>
        where TMethod : IEditableClassMethod
        where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod
    {
        public EditableClassMethodCollectionWrapper(IEditableClassMethodCollection<TMethod, TExplicitInterfaceMethod> methods)
        {
            WrappedObject = methods;
        }

        public IEditableClassMethodCollection<TMethod, TExplicitInterfaceMethod> WrappedObject { get; private set; }

        public override ICollection<TExplicitInterfaceMethod> ExplicitInterfaceMethods
        {
            get => WrappedObject.ExplicitInterfaceMethods;
            set => WrappedObject.ExplicitInterfaceMethods = value;
        }

        public override ICollection<TMethod> Methods
        {
            get => WrappedObject;
            set => throw new NotImplementedException();
        }
    }
}