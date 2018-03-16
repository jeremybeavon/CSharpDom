using CSharpDom.Common;
using CSharpDom.Common.Editable;
using System;
using System.Collections.Generic;

namespace CSharpDom.BaseClasses.Editable.Wrappers
{
    public sealed class EditableSealedClassMethodCollectionWrapper<TMethod, TExplicitInterfaceMethod> :
        EditableSealedClassMethodCollection<TMethod, TExplicitInterfaceMethod>,
        IWrapper<IEditableSealedClassMethodCollection<TMethod, TExplicitInterfaceMethod>>
        where TMethod : IEditableSealedClassMethod
        where TExplicitInterfaceMethod : IEditableExplicitInterfaceMethod
    {
        public EditableSealedClassMethodCollectionWrapper(IEditableSealedClassMethodCollection<TMethod, TExplicitInterfaceMethod> methods)
        {
            WrappedObject = methods;
        }

        public IEditableSealedClassMethodCollection<TMethod, TExplicitInterfaceMethod> WrappedObject { get; private set; }

        public override IReadOnlyCollection<TExplicitInterfaceMethod> ExplicitInterfaceMethods => WrappedObject.ExplicitInterfaceMethods;

        protected override IReadOnlyCollection<TMethod> Methods => WrappedObject;
    }
}