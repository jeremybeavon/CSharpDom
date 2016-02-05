﻿using System;
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
            UsingDirective,
            AttributeGroup,
            Namespace, 
            Class,
            Delegate,
            Enum,
            Interface,
            Struct>
    {
        public LoadedDocument()
        {
            AssemblyAttributes = new List<AttributeGroup>();
            Classes = new List<Class>();
            Delegates = new List<Delegate>();
            Enums = new List<Enum>();
            Interfaces = new List<Interface>();
            ModuleAttributes = new List<AttributeGroup>();
            Structs = new List<Struct>();
            UsingDirectives = new List<UsingDirective>();
        }

        public List<AttributeGroup> AssemblyAttributes { get; set; }

        public List<Class> Classes { get; set; }

        public List<Delegate> Delegates { get; set; }

        public DocumentNotSupported Document
        {
            get { return null; }
        }

        public List<Enum> Enums { get; set; }

        public List<Interface> Interfaces { get; set; }

        public List<AttributeGroup> ModuleAttributes { get; set; }

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

        public List<UsingDirective> UsingDirectives { get; set; }

        IReadOnlyCollection<AttributeGroup> IHasAssemblyAttributes<AttributeGroup>.AssemblyAttributes
        {
            get { return AssemblyAttributes; }
        }

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

        IReadOnlyCollection<AttributeGroup> IHasModuleAttributes<AttributeGroup>.ModuleAttributes
        {
            get { return ModuleAttributes; }
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
            visitor.VisitLoadedDocument(this);
        }

        public void AcceptChildren(IGenericVisitor visitor)
        {
            GenericVisitor.VisitLoadedDocumentChildren(this, visitor);
        }
    }
}