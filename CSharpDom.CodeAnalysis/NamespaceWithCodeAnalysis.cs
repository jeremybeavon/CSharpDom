using CSharpDom.NotSupported;
using CSharpDom.CodeAnalysis.Internal;
using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;

namespace CSharpDom.CodeAnalysis
{
    public sealed class NamespaceWithCodeAnalysis :
        AbstractNamespace<
            UsingDirectiveNotSupported,
            NamespaceNotSupported,
            ClassCollectionWithCodeAnalysis,
            DelegateWithCodeAnalysis,
            EnumWithCodeAnalysis,
            InterfaceCollectionWithCodeAnalysis,
            StructCollectionWithCodeAnalysis>//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly string name;
        private readonly TypeContainer typeContainer;
        private readonly ClassCollectionWithCodeAnalysis classes;
        private readonly InterfaceCollectionWithCodeAnalysis interfaces;
        private readonly StructCollectionWithCodeAnalysis structs;

        internal NamespaceWithCodeAnalysis(string name, TypeContainer typeContainer)
        {
            this.name = name;
            this.typeContainer = typeContainer;
            classes = new ClassCollectionWithCodeAnalysis(typeContainer);
            interfaces = new InterfaceCollectionWithCodeAnalysis(typeContainer);
            structs = new StructCollectionWithCodeAnalysis(typeContainer);
        }

        public override ClassCollectionWithCodeAnalysis Classes
        {
            get { return classes; }
        }

        public override IReadOnlyCollection<DelegateWithCodeAnalysis> Delegates
        {
            get { return typeContainer.Delegates; }
        }

        public override IReadOnlyCollection<EnumWithCodeAnalysis> Enums
        {
            get { return typeContainer.Enums; }
        }

        public override InterfaceCollectionWithCodeAnalysis Interfaces
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

        public override StructCollectionWithCodeAnalysis Structs
        {
            get { return structs; }
        }

        public override IReadOnlyCollection<UsingDirectiveNotSupported> UsingDirectives
        {
            get { return new UsingDirectiveNotSupported[0]; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitNamespaceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
