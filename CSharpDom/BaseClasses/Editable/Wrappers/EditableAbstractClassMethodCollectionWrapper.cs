using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Common.Editable;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableAbstractClassMethodCollectionWrapper<TMethod, TAbstractMethod, TExplicitInterfaceMethod> :
        EditableAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>,
        IWrapper<IEditableAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod>>
        where TMethod : IEditableClassMethod
        where TAbstractMethod : IEditableAbstractMethod
        where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod
    {
        public EditableAbstractClassMethodCollectionWrapper(IEditableAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod> methods)
        {
            WrappedObject = methods;
        }

        public IEditableAbstractClassMethodCollection<TMethod, TAbstractMethod, TExplicitInterfaceMethod> WrappedObject { get; private set; }

        public override ICollection<TAbstractMethod> AbstractMethods
        {
            get => WrappedObject.AbstractMethods;
            set => WrappedObject.AbstractMethods = value;
        }

        public override ICollection<TExplicitInterfaceMethod> ExplicitInterfaceMethods
        {
            get => WrappedObject.ExplicitInterfaceMethods;
            set => WrappedObject.ExplicitInterfaceMethods = value;
        }

        public override ICollection<TMethod> Methods
        {
            get => WrappedObject;
            set => throw new NotSupportedException();
        }
    }
}