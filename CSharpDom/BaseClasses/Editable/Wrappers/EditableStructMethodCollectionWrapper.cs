using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableStructMethodCollectionWrapper<TMethod, TExplicitInterfaceMethod> :
        EditableStructMethodCollection<TMethod, TExplicitInterfaceMethod>,
        IWrapper<IEditableStructMethodCollection<TMethod, TExplicitInterfaceMethod>>
        where TMethod : IEditableStructMethod
        where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod
    {
        public EditableStructMethodCollectionWrapper(IEditableStructMethodCollection<TMethod, TExplicitInterfaceMethod> methods)
        {
            WrappedObject = methods;
        }

        public IEditableStructMethodCollection<TMethod, TExplicitInterfaceMethod> WrappedObject { get; private set; }

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