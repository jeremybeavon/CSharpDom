using CSharpDom.NotSupported;
using CSharpDom.Mono.Cecil.Internal;
using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.Mono.Cecil
{
    public sealed class NamespaceWithMonoCecil :
        AbstractNamespace<
            UsingDirectiveNotSupported,
            NamespaceNotSupported,
            ClassCollectionWithMonoCecil,
            DelegateWithMonoCecil,
            EnumWithMonoCecil,
            InterfaceCollectionWithMonoCecil,
            StructCollectionWithMonoCecil>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly string name;
        private readonly TypeContainer typeContainer;
        private readonly ClassCollectionWithMonoCecil classes;
        private readonly InterfaceCollectionWithMonoCecil interfaces;
        private readonly StructCollectionWithMonoCecil structs;

        internal NamespaceWithMonoCecil(string name, TypeContainer typeContainer)
        {
            this.name = name;
            this.typeContainer = typeContainer;
            classes = new ClassCollectionWithMonoCecil(typeContainer);
            interfaces = new InterfaceCollectionWithMonoCecil(typeContainer);
            structs = new StructCollectionWithMonoCecil(typeContainer);
        }

        public override ClassCollectionWithMonoCecil Classes
        {
            get { return classes; }
        }

        public override IReadOnlyCollection<DelegateWithMonoCecil> Delegates
        {
            get { return typeContainer.Delegates; }
        }

        public override IReadOnlyCollection<EnumWithMonoCecil> Enums
        {
            get { return typeContainer.Enums; }
        }

        public override InterfaceCollectionWithMonoCecil Interfaces
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

        public override StructCollectionWithMonoCecil Structs
        {
            get { return structs; }
        }

        public override IReadOnlyCollection<UsingDirectiveNotSupported> UsingDirectives
        {
            get { return new UsingDirectiveNotSupported[0]; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNamespaceWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
