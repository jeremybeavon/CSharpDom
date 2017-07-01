using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using CSharpDom.Reflection.Internal;
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace CSharpDom.Reflection
{
    public sealed class AssemblyWithReflection :
        AbstractLoadedDocument<
            AssemblyWithReflection,
            AssemblyWithReflection,
            AssemblyWithReflection,
            UsingDirectiveNotSupported,
            AttributeGroupNotSupported,
            NamespaceWithReflection,
            ClassCollectionWithReflection,
            DelegateWithReflection,
            EnumWithReflection,
            InterfaceWithReflection,
            StructCollectionWithReflection>,
        ISolution<AssemblyWithReflection>,
        IProject<AssemblyWithReflection, AssemblyWithReflection, AssemblyWithReflection>,
        IDocument<AssemblyWithReflection, AssemblyWithReflection, AssemblyWithReflection>,
        ILoadedProject<
            AssemblyWithReflection,
            AssemblyWithReflection,
            NamespaceWithReflection,
            ClassCollectionWithReflection,
            DelegateWithReflection,
            EnumWithReflection,
            InterfaceWithReflection,
            StructCollectionWithReflection>,

        IHasAssembly//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Assembly assembly;
        private readonly TypeContainer typeContainer;
        private readonly IReadOnlyCollection<NamespaceWithReflection> namespaces;
        private readonly ClassCollectionWithReflection classes;
        private readonly IReadOnlyCollection<InterfaceWithReflection> interfaces;
        private readonly StructCollectionWithReflection structs;

        public AssemblyWithReflection(Assembly assembly)
        {
            this.assembly = assembly;
            ConcurrentDictionary<string, NamespaceContainer> namespaces = new ConcurrentDictionary<string, NamespaceContainer>();
            foreach (Type type in assembly.GetTypes().Where(type => type.DeclaringType == null))
            {
                NamespaceContainer namespaceContainer = namespaces.GetOrAdd(
                    type.Namespace ?? string.Empty,
                    name => new NamespaceContainer(name));
                NamespaceWithReflection @namespace = namespaceContainer.Namespace;
                TypeContainer typeContainer = namespaceContainer.TypeContainer;
                AddTypeToContainer(type, typeContainer, @namespace);
            }

            this.typeContainer = namespaces.GetOrAdd(string.Empty, name => new NamespaceContainer(name)).TypeContainer;
            this.namespaces = namespaces.Values
                .Select(container => container.Namespace)
                .Where(@namespace => @namespace.Name.Length != 0)
                .ToList();
            classes = new ClassCollectionWithReflection(this.typeContainer);
            //interfaces = new InterfaceCollectionWithReflection(this.typeContainer);
            structs = new StructCollectionWithReflection(this.typeContainer);
        }

        public override ClassCollectionWithReflection Classes
        {
            get { return classes; }
        }

        public override IReadOnlyCollection<DelegateWithReflection> Delegates
        {
            get { return typeContainer.Delegates; }
        }

        public override AssemblyWithReflection Document
        {
            get { return this; }
        }

        public override IReadOnlyCollection<EnumWithReflection> Enums
        {
            get { return typeContainer.Enums; }
        }

        public string FullFilePath
        {
            get { return assembly.Location; }
        }

        public override IReadOnlyCollection<InterfaceWithReflection> Interfaces
        {
            get { return interfaces; }
        }

        public override IReadOnlyCollection<NamespaceWithReflection> Namespaces
        {
            get { return namespaces; }
        }

        public override AssemblyWithReflection Project
        {
            get { return this; }
        }
        
        public override AssemblyWithReflection Solution
        {
            get { return this; }
        }

        public override StructCollectionWithReflection Structs
        {
            get { return structs; }
        }

        IReadOnlyCollection<AssemblyWithReflection> IHasDocuments<AssemblyWithReflection>.Documents
        {
            get { return new AssemblyWithReflection[] { this }; }
        }
        
        IReadOnlyCollection<AssemblyWithReflection> ISolution<AssemblyWithReflection>.Projects
        {
            get { return new AssemblyWithReflection[] { this }; }
        }

        public Assembly Assembly
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

        public SolutionWithReflection AsSolution()
        {
            return new SolutionWithReflection(this);
        }

        public ProjectWithReflection AsProject()
        {
            return new ProjectWithReflection(AsSolution(), this);
        }

        public DocumentWithReflection AsDocument()
        {
            return new DocumentWithReflection(AsProject(), this);
        }

        Task IAsyncVisitable<IGenericVisitor>.AcceptAsync(IGenericVisitor visitor)
        {
            return visitor.VisitDocumentAsync(this);
        }

        Task IAsyncVisitable<IGenericVisitor>.AcceptChildrenAsync(IGenericVisitor visitor)
        {
            return GenericVisitor.VisitDocumentChildrenAsync(this, visitor);
        }

        Task<AssemblyWithReflection> IDocument<AssemblyWithReflection, AssemblyWithReflection, AssemblyWithReflection>.LoadAsync()
        {
            return Task.FromResult(this);
        }

        Task<AssemblyWithReflection> IProject<AssemblyWithReflection, AssemblyWithReflection, AssemblyWithReflection>.LoadAsync()
        {
            return Task.FromResult(this);
        }

        private void AddTypeToContainer(Type type, TypeContainer typeContainer, NamespaceWithReflection @namespace)
        {
            switch (type.TypeClassification())
            {
                case TypeClassification.AbstractClass:
                    typeContainer.AbstractClasses.Add(new AbstractClassWithReflection(this, @namespace, type));
                    break;
                case TypeClassification.Class:
                    typeContainer.Classes.Add(new ClassWithReflection(this, @namespace, type));
                    break;
                case TypeClassification.SealedClass:
                    typeContainer.SealedClasses.Add(new SealedClassWithReflection(this, @namespace, type));
                    break;
                case TypeClassification.StaticClass:
                    typeContainer.StaticClasses.Add(new StaticClassWithReflection(this, @namespace, type));
                    break;
                case TypeClassification.Delegate:
                    typeContainer.Delegates.Add(new DelegateWithReflection(this, @namespace, type));
                    break;
                case TypeClassification.Enum:
                    typeContainer.Enums.Add(new EnumWithReflection(this, @namespace, type));
                    break;
                case TypeClassification.Interface:
                    typeContainer.Interfaces.Add(new InterfaceWithReflection(this, @namespace, type));
                    break;
                case TypeClassification.Struct:
                    typeContainer.Structs.Add(new StructWithReflection(this, @namespace, type));
                    break;
            }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitAssemblyWithReflection(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
