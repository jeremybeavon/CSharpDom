using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.Serialization
{
    public sealed class LoadedDocument :
        ILoadedDocument<
            SolutionNotSupported,
            ProjectNotSupported,
            DocumentNotSupported,
            Namespace, 
            Class,
            Delegate,
            Enum,
            Interface,
            Struct>
    {
        public LoadedDocument()
        {
            Classes = new List<Class>();
            Delegates = new List<Delegate>();
            Enums = new List<Enum>();
            Interfaces = new List<Interface>();
            Structs = new List<Struct>();
        }

        public List<Class> Classes { get; set; }

        public List<Delegate> Delegates { get; set; }

        public DocumentNotSupported Document
        {
            get { return null; }
        }

        public List<Enum> Enums { get; set; }

        public List<Interface> Interfaces { get; set; }

        public string Name { get; set; }

        public List<Namespace> Namespaces { get; set; }

        public ProjectNotSupported Project
        {
            get { return null; }
        }

        public SolutionNotSupported Solution
        {
            get { return null; }
        }

        public List<Struct> Structs { get; set; }

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

        public void Accept(IGenericVisitor visitor)
        {
            visitor.VisitLoadedDocument(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitLoadedDocumentChildren(this, visitor);
        }
    }
}
