using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.Mono.Cecil.Internal;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpDom.Mono.Cecil
{
    public sealed class AssemblyWithMonoCecil :
        AbstractLoadedDocument<
            AssemblyWithMonoCecil,
            AssemblyWithMonoCecil,
            AssemblyWithMonoCecil,
            UsingDirectiveNotSupported,
            AttributeGroupNotSupported,
            NamespaceWithMonoCecil,
            ClassCollectionWithMonoCecil,
            DelegateWithMonoCecil,
            EnumWithMonoCecil,
            InterfaceCollectionWithMonoCecil,
            StructCollectionWithMonoCecil>,
        ISolution<AssemblyWithMonoCecil>,
        IProject<AssemblyWithMonoCecil, AssemblyWithMonoCecil, AssemblyWithMonoCecil>,
        IDocument<AssemblyWithMonoCecil, AssemblyWithMonoCecil, AssemblyWithMonoCecil>,
        ILoadedProject<
            AssemblyWithMonoCecil,
            AssemblyWithMonoCecil,
            NamespaceWithMonoCecil,
            ClassCollectionWithMonoCecil,
            DelegateWithMonoCecil,
            EnumWithMonoCecil,
            InterfaceCollectionWithMonoCecil,
            StructCollectionWithMonoCecil>,

        IHasAssemblyDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly AssemblyDefinition assembly;
        private readonly TypeContainer typeContainer;
        private readonly IReadOnlyCollection<NamespaceWithMonoCecil> namespaces;
        private readonly ClassCollectionWithMonoCecil classes;
        private readonly InterfaceCollectionWithMonoCecil interfaces;
        private readonly StructCollectionWithMonoCecil structs;

        public AssemblyWithMonoCecil(AssemblyDefinition assembly)
        {
            this.assembly = assembly;
            ConcurrentDictionary<string, NamespaceContainer> namespaces = new ConcurrentDictionary<string, NamespaceContainer>();
            foreach (TypeDefinition type in assembly.Modules.SelectMany(module => module.Types))
            {
                NamespaceContainer namespaceContainer = namespaces.GetOrAdd(
                    type.Namespace ?? string.Empty,
                    name => new NamespaceContainer(name));
                NamespaceWithMonoCecil @namespace = namespaceContainer.Namespace;
                TypeContainer typeContainer = namespaceContainer.TypeContainer;
                AddTypeToContainer(type, typeContainer, @namespace);
            }

            this.typeContainer = namespaces.GetOrAdd(string.Empty, name => new NamespaceContainer(name)).TypeContainer;
            this.namespaces = namespaces.Values
                .Select(container => container.Namespace)
                .Where(@namespace => @namespace.Name.Length != 0)
                .ToList();
            classes = new ClassCollectionWithMonoCecil(this.typeContainer);
            interfaces = new InterfaceCollectionWithMonoCecil(this.typeContainer);
            structs = new StructCollectionWithMonoCecil(this.typeContainer);
        }

        public override ClassCollectionWithMonoCecil Classes
        {
            get { return classes; }
        }

        public override IReadOnlyCollection<DelegateWithMonoCecil> Delegates
        {
            get { return typeContainer.Delegates; }
        }

        public override AssemblyWithMonoCecil Document
        {
            get { return this; }
        }

        public override IReadOnlyCollection<EnumWithMonoCecil> Enums
        {
            get { return typeContainer.Enums; }
        }

        public string FullFilePath
        {
            get { throw new NotImplementedException(); }
        }

        public override InterfaceCollectionWithMonoCecil Interfaces
        {
            get { return interfaces; }
        }

        public override IReadOnlyCollection<NamespaceWithMonoCecil> Namespaces
        {
            get { return namespaces; }
        }

        public override AssemblyWithMonoCecil Project
        {
            get { return this; }
        }
        
        public override AssemblyWithMonoCecil Solution
        {
            get { return this; }
        }

        public override StructCollectionWithMonoCecil Structs
        {
            get { return structs; }
        }

        IReadOnlyCollection<AssemblyWithMonoCecil> IHasDocuments<AssemblyWithMonoCecil>.Documents
        {
            get { return new AssemblyWithMonoCecil[] { this }; }
        }
        
        IReadOnlyCollection<AssemblyWithMonoCecil> ISolution<AssemblyWithMonoCecil>.Projects
        {
            get { return new AssemblyWithMonoCecil[] { this }; }
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

        public SolutionWithMonoCecil AsSolution()
        {
            return new SolutionWithMonoCecil(this);
        }

        public ProjectWithMonoCecil AsProject()
        {
            return new ProjectWithMonoCecil(AsSolution(), this);
        }

        public DocumentWithMonoCecil AsDocument()
        {
            return new DocumentWithMonoCecil(AsProject(), this);
        }

        Task IAsyncVisitable<IGenericVisitor>.AcceptAsync(IGenericVisitor visitor)
        {
            return visitor.VisitDocumentAsync(this);
        }

        Task IAsyncVisitable<IGenericVisitor>.AcceptChildrenAsync(IGenericVisitor visitor)
        {
            return GenericVisitor.VisitDocumentChildrenAsync(this, visitor);
        }

        Task<AssemblyWithMonoCecil> IDocument<AssemblyWithMonoCecil, AssemblyWithMonoCecil, AssemblyWithMonoCecil>.LoadAsync()
        {
            return Task.FromResult(this);
        }

        Task<AssemblyWithMonoCecil> IProject<AssemblyWithMonoCecil, AssemblyWithMonoCecil, AssemblyWithMonoCecil>.LoadAsync()
        {
            return Task.FromResult(this);
        }

        private void AddTypeToContainer(TypeDefinition type, TypeContainer typeContainer, NamespaceWithMonoCecil @namespace)
        {
            switch (type.TypeClassification())
            {
                case TypeClassification.AbstractClass:
                    typeContainer.AbstractClasses.Add(new AbstractClassWithMonoCecil(this, @namespace, type));
                    break;
                case TypeClassification.Class:
                    typeContainer.Classes.Add(new ClassWithMonoCecil(this, @namespace, type));
                    break;
                case TypeClassification.SealedClass:
                    typeContainer.SealedClasses.Add(new SealedClassWithMonoCecil(this, @namespace, type));
                    break;
                case TypeClassification.StaticClass:
                    typeContainer.StaticClasses.Add(new StaticClassWithMonoCecil(this, @namespace, type));
                    break;
                case TypeClassification.Delegate:
                    typeContainer.Delegates.Add(new DelegateWithMonoCecil(this, @namespace, type));
                    break;
                case TypeClassification.Enum:
                    typeContainer.Enums.Add(new EnumWithMonoCecil(this, @namespace, type));
                    break;
                case TypeClassification.Interface:
                    typeContainer.Interfaces.Add(new InterfaceWithMonoCecil(this, @namespace, type));
                    break;
                case TypeClassification.Struct:
                    typeContainer.Structs.Add(new StructWithMonoCecil(this, @namespace, type));
                    break;
            }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitAssemblyWithMonoCecil(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
