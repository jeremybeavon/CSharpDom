using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.BaseClasses
{
    public abstract class AbstractNamespace<TClass, TDelegate, TEnum, TInterface, TStruct> :
        INamespace<TClass, TDelegate, TEnum, TInterface, TStruct>
        where TClass : IClass
        where TDelegate : IDelegate
        where TEnum : IEnum
        where TInterface : IInterface
        where TStruct : IStruct
    {
        public abstract IReadOnlyCollection<TClass> Classes { get; }

        public abstract IReadOnlyCollection<TDelegate> Delegates { get; }

        public abstract IReadOnlyCollection<TEnum> Enums { get; }

        public abstract IReadOnlyCollection<TInterface> Interfaces { get; }

        public abstract string Name { get; }

        public abstract IReadOnlyCollection<TStruct> Structs { get; }

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitNamespace(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitNamespaceChildren(this, visitor);
        }
    }
}
