using CSharpDom.NotSupported;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Reflection
{
    public sealed class NamespaceWithReflection :
        AbstractNamespace<
            UsingDirectiveNotSupported,
            NamespaceNotSupported,
            ClassWithReflection,
            DelegateWithReflection,
            EnumWithReflection,
            InterfaceWithReflection,
            StructWithReflection>,
        IVisitable<IReflectionVisitor>
    {
        private readonly string name;
        private readonly TypeContainer typeContainer;

        internal NamespaceWithReflection(string name, TypeContainer typeContainer)
        {
            this.name = name;
            this.typeContainer = typeContainer;
        }

        public override IReadOnlyCollection<ClassWithReflection> Classes
        {
            get { return typeContainer.Classes; }
        }

        public override IReadOnlyCollection<DelegateWithReflection> Delegates
        {
            get { return typeContainer.Delegates; }
        }

        public override IReadOnlyCollection<EnumWithReflection> Enums
        {
            get { return typeContainer.Enums; }
        }

        public override IReadOnlyCollection<InterfaceWithReflection> Interfaces
        {
            get { return typeContainer.Interfaces; }
        }

        public override string Name
        {
            get { return name; }
        }

        public override IReadOnlyCollection<NamespaceNotSupported> Namespaces
        {
            get { return new NamespaceNotSupported[0]; }
        }

        public override IReadOnlyCollection<StructWithReflection> Structs
        {
            get { return typeContainer.Structs; }
        }

        public override IReadOnlyCollection<UsingDirectiveNotSupported> UsingDirectives
        {
            get { return new UsingDirectiveNotSupported[0]; }
        }

        public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNamespaceWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }
    }
}
