using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    public sealed class AssemblyWithCodeAnalysis :
        AbstractLoadedDocument<
            AssemblyWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            UsingDirectiveNotSupported,
            AttributeGroupNotSupported,
            NamespaceWithCodeAnalysis,
            ClassCollectionWithCodeAnalysis,
            DelegateWithCodeAnalysis,
            EnumWithCodeAnalysis,
            InterfaceCollectionWithCodeAnalysis,
            StructCollectionWithCodeAnalysis>,
        ISolution<AssemblyWithCodeAnalysis>,
        IProject<AssemblyWithCodeAnalysis, AssemblyWithCodeAnalysis, AssemblyWithCodeAnalysis>,
        IDocument<AssemblyWithCodeAnalysis, AssemblyWithCodeAnalysis, AssemblyWithCodeAnalysis>,
        ILoadedProject<
            AssemblyWithCodeAnalysis,
            AssemblyWithCodeAnalysis,
            NamespaceWithCodeAnalysis,
            ClassCollectionWithCodeAnalysis,
            DelegateWithCodeAnalysis,
            EnumWithCodeAnalysis,
            InterfaceCollectionWithCodeAnalysis,
            StructCollectionWithCodeAnalysis>,

        IHasAssemblyDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyDefinition assembly;
        private readonly TypeContainer typeContainer;
        private readonly IReadOnlyCollection<NamespaceWithCodeAnalysis> namespaces;
        private readonly ClassCollectionWithCodeAnalysis classes;
        private readonly InterfaceCollectionWithCodeAnalysis interfaces;
        private readonly StructCollectionWithCodeAnalysis structs;

        public AssemblyWithCodeAnalysis(AssemblyDefinition assembly)
        {
            this.assembly = assembly;
            ConcurrentDictionary<string, NamespaceContainer> namespaces = new ConcurrentDictionary<string, NamespaceContainer>();
            foreach (TypeDefinition type in assembly.Modules.SelectMany(module => module.Types))
            {
                NamespaceContainer namespaceContainer = namespaces.GetOrAdd(
                    type.Namespace ?? string.Empty,
                    name => new NamespaceContainer(name));
                NamespaceWithCodeAnalysis @namespace = namespaceContainer.Namespace;
                TypeContainer typeContainer = namespaceContainer.TypeContainer;
                AddTypeToContainer(type, typeContainer, @namespace);
            }

            this.typeContainer = namespaces.GetOrAdd(string.Empty, name => new NamespaceContainer(name)).TypeContainer;
            this.namespaces = namespaces.Values
                .Select(container => container.Namespace)
                .Where(@namespace => @namespace.Name.Length != 0)
                .ToList();
            classes = new ClassCollectionWithCodeAnalysis(this.typeContainer);
            interfaces = new InterfaceCollectionWithCodeAnalysis(this.typeContainer);
            structs = new StructCollectionWithCodeAnalysis(this.typeContainer);
        }

        public override ClassCollectionWithCodeAnalysis Classes
        {
            get { return classes; }
        }

        public override IReadOnlyCollection<DelegateWithCodeAnalysis> Delegates
        {
            get { return typeContainer.Delegates; }
        }

        public override AssemblyWithCodeAnalysis Document
        {
            get { return this; }
        }

        public override IReadOnlyCollection<EnumWithCodeAnalysis> Enums
        {
            get { return typeContainer.Enums; }
        }

        public string FullFilePath
        {
            get { throw new NotImplementedException(); }
        }

        public override InterfaceCollectionWithCodeAnalysis Interfaces
        {
            get { return interfaces; }
        }

        public override IReadOnlyCollection<NamespaceWithCodeAnalysis> Namespaces
        {
            get { return namespaces; }
        }

        public override AssemblyWithCodeAnalysis Project
        {
            get { return this; }
        }
        
        public override AssemblyWithCodeAnalysis Solution
        {
            get { return this; }
        }

        public override StructCollectionWithCodeAnalysis Structs
        {
            get { return structs; }
        }

        IReadOnlyCollection<AssemblyWithCodeAnalysis> IHasDocuments<AssemblyWithCodeAnalysis>.Documents
        {
            get { return new AssemblyWithCodeAnalysis[] { this }; }
        }
        
        IReadOnlyCollection<AssemblyWithCodeAnalysis> ISolution<AssemblyWithCodeAnalysis>.Projects
        {
            get { return new AssemblyWithCodeAnalysis[] { this }; }
        }

        public AssemblyDefinition Assembly
        {
            get { return assembly; }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> AssemblyAttributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> ModuleAttributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override IReadOnlyCollection<UsingDirectiveNotSupported> UsingDirectives
        {
            get { return new UsingDirectiveNotSupported[0]; }
        }

        public SolutionWithCodeAnalysis AsSolution()
        {
            return new SolutionWithCodeAnalysis(this);
        }

        public ProjectWithCodeAnalysis AsProject()
        {
            return new ProjectWithCodeAnalysis(AsSolution(), this);
        }

        public DocumentWithCodeAnalysis AsDocument()
        {
            return new DocumentWithCodeAnalysis(AsProject(), this);
        }

        Task IAsyncVisitable<IGenericVisitor>.AcceptAsync(IGenericVisitor visitor)
        {
            return visitor.VisitDocumentAsync(this);
        }

        Task IAsyncVisitable<IGenericVisitor>.AcceptChildrenAsync(IGenericVisitor visitor)
        {
            return GenericVisitor.VisitDocumentChildrenAsync(this, visitor);
        }

        Task<AssemblyWithCodeAnalysis> IDocument<AssemblyWithCodeAnalysis, AssemblyWithCodeAnalysis, AssemblyWithCodeAnalysis>.LoadAsync()
        {
            return Task.FromResult(this);
        }

        Task<AssemblyWithCodeAnalysis> IProject<AssemblyWithCodeAnalysis, AssemblyWithCodeAnalysis, AssemblyWithCodeAnalysis>.LoadAsync()
        {
            return Task.FromResult(this);
        }

        private void AddTypeToContainer(TypeDefinition type, TypeContainer typeContainer, NamespaceWithCodeAnalysis @namespace)
        {
            switch (type.TypeClassification())
            {
                case TypeClassification.AbstractClass:
                    typeContainer.AbstractClasses.Add(new AbstractClassWithCodeAnalysis(this, @namespace, type));
                    break;
                case TypeClassification.Class:
                    typeContainer.Classes.Add(new ClassWithCodeAnalysis(this, @namespace, type));
                    break;
                case TypeClassification.SealedClass:
                    typeContainer.SealedClasses.Add(new SealedClassWithCodeAnalysis(this, @namespace, type));
                    break;
                case TypeClassification.StaticClass:
                    typeContainer.StaticClasses.Add(new StaticClassWithCodeAnalysis(this, @namespace, type));
                    break;
                case TypeClassification.Delegate:
                    typeContainer.Delegates.Add(new DelegateWithCodeAnalysis(this, @namespace, type));
                    break;
                case TypeClassification.Enum:
                    typeContainer.Enums.Add(new EnumWithCodeAnalysis(this, @namespace, type));
                    break;
                case TypeClassification.Interface:
                    typeContainer.Interfaces.Add(new InterfaceWithCodeAnalysis(this, @namespace, type));
                    break;
                case TypeClassification.Struct:
                    typeContainer.Structs.Add(new StructWithCodeAnalysis(this, @namespace, type));
                    break;
            }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitAssemblyWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
