using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Serialization
{
    public sealed class Namespace : INamespace<UsingDirective, Namespace, Class, Delegate, Enum, Interface, Struct>
    {
        public Namespace()
        {
            Classes = new List<Class>();
            Delegates = new List<Delegate>();
            Enums = new List<Enum>();
            Interfaces = new List<Interface>();
            Namespaces = new List<Namespace>();
            Structs = new List<Struct>();
            UsingDirectives = new List<UsingDirective>();
        }

        public List<Class> Classes { get; set; }

        public List<Delegate> Delegates { get; set; }

        public List<Enum> Enums { get; set; }

        public List<Interface> Interfaces { get; set; }

        public string Name { get; set; }

        public List<Namespace> Namespaces { get; set; }

        public List<Struct> Structs { get; set; }

        public List<UsingDirective> UsingDirectives { get; set; }

        IReadOnlyCollection<Class> IHasClasses<Class>.Classes
        {
            get { return Classes; }
        }

        IReadOnlyCollection<Delegate> IHasDelegates<Delegate>.Delegates
        {
            get { return Delegates; }
        }

        IReadOnlyCollection<Enum> IHasEnums<Enum>.Enums
        {
            get { return Enums; }
        }

        IReadOnlyCollection<Interface> IHasInterfaces<Interface>.Interfaces
        {
            get { return Interfaces; }
        }

        IReadOnlyCollection<Namespace> IHasNamespaces<Namespace>.Namespaces
        {
            get { return Namespaces; }
        }

        IReadOnlyCollection<Struct> IHasStructs<Struct>.Structs
        {
            get { return Structs; }
        }

        IReadOnlyCollection<UsingDirective> IHasUsingDirectives<UsingDirective>.UsingDirectives
        {
            get { return UsingDirectives; }
        }

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
