using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class Namespace :
        INamespace<UsingDirective, Namespace, ClassCollection, Delegate, Enum, Interface, StructCollection>
    {
        public Namespace()
        {
            Classes = new ClassCollection();
            Delegates = new List<Delegate>();
            Enums = new List<Enum>();
            Interfaces = new List<Interface>();
            Namespaces = new List<Namespace>();
            Structs = new StructCollection();
            UsingDirectives = new List<UsingDirective>();
        }

        public ClassCollection Classes { get; set; }

        public List<Delegate> Delegates { get; set; }

        public List<Enum> Enums { get; set; }

        public List<Interface> Interfaces { get; set; }

        public string Name { get; set; }

        public List<Namespace> Namespaces { get; set; }

        public StructCollection Structs { get; set; }

        public List<UsingDirective> UsingDirectives { get; set; }
        
        IReadOnlyCollection<Delegate> IHasDelegates<Delegate>.Delegates
        {
            get { return Delegates; }
        }

        IReadOnlyCollection<Enum> IHasEnums<Enum>.Enums
        {
            get { return Enums; }
        }
        
        IReadOnlyCollection<Namespace> IHasNamespaces<Namespace>.Namespaces
        {
            get { return Namespaces; }
        }
        
        IReadOnlyCollection<UsingDirective> IHasUsingDirectives<UsingDirective>.UsingDirectives
        {
            get { return UsingDirectives; }
        }

        IReadOnlyCollection<Interface> IHasInterfaces<Interface>.Interfaces => Interfaces;

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
