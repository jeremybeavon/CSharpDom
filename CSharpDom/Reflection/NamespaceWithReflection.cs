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
            ClassCollectionWithReflection,
            DelegateWithReflection,
            EnumWithReflection,
            InterfaceCollectionWithReflection,
            StructCollectionWithReflection>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly string name;
        private readonly TypeContainer typeContainer;
        private readonly ClassCollectionWithReflection classes;
        private readonly InterfaceCollectionWithReflection interfaces;
        private readonly StructCollectionWithReflection structs;

        internal NamespaceWithReflection(string name, TypeContainer typeContainer)
        {
            this.name = name;
            this.typeContainer = typeContainer;
            classes = new ClassCollectionWithReflection(typeContainer);
            interfaces = new InterfaceCollectionWithReflection(typeContainer);
            structs = new StructCollectionWithReflection(typeContainer);
        }

        public override ClassCollectionWithReflection Classes
        {
            get { return classes; }
        }

        public override IReadOnlyCollection<DelegateWithReflection> Delegates
        {
            get { return typeContainer.Delegates; }
        }

        public override IReadOnlyCollection<EnumWithReflection> Enums
        {
            get { return typeContainer.Enums; }
        }

        public override InterfaceCollectionWithReflection Interfaces
        {
            get { return interfaces; }
        }

        public override string Name
        {
            get { return name; }
        }

        public override IReadOnlyCollection<NamespaceNotSupported> Namespaces
        {
            get { return new NamespaceNotSupported[0]; }
        }

        public override StructCollectionWithReflection Structs
        {
            get { return structs; }
        }

        public override IReadOnlyCollection<UsingDirectiveNotSupported> UsingDirectives
        {
            get { return new UsingDirectiveNotSupported[0]; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNamespaceWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
