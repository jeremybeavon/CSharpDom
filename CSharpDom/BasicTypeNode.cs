using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom
{
    internal abstract class BasicTypeNode<TDeclarationNode, TDeclaration> : AbstractNode, ITypeName, IBasicCompositeType
        where TDeclarationNode : BasicMemberContainer<TDeclaration>
        where TDeclaration : TypeDeclarationSyntax
    {
        private IReadOnlyCollection<EventNode> events;
        private IReadOnlyCollection<IndexerNode> indexers;
        private IReadOnlyCollection<PropertyNode> properties;
        private IReadOnlyCollection<MethodNode> methods;

        protected BasicTypeNode(TDeclaration declaration, ITypeContainer container)
        {
            Container = container;
            Declarations = new Collection<TDeclarationNode>();
            TypeName = new TypeNameNode(declaration);
        }

        public ITypeContainer Container { get; private set; }

        public TypeNameNode TypeName { get; private set; }

        public bool IsNestedType
        {
            get { return Declarations[0].IsNestedType; }
        }

        public string Name
        {
            get { return TypeName.Name; }
        }

        public int GenericParameterCount
        {
            get { return TypeName.GenericParameterCount; }
        }

        public string NameWithGenericParameterCount
        {
            get { return TypeName.NameWithGenericParameterCount; }
        }

        public Collection<TDeclarationNode> Declarations { get; private set; }

        public IReadOnlyCollection<EventNode> Events
        {
            get
            {
                if (events == null)
                {
                    events = CreateReadOnlyCollection(declaration => declaration.Events);
                }

                return events;
            }
        }

        public IReadOnlyCollection<IndexerNode> Indexers
        {
            get
            {
                if (indexers == null)
                {
                    indexers = CreateReadOnlyCollection(declaration => declaration.Indexers);
                }

                return indexers;
            }
        }

        public IReadOnlyCollection<PropertyNode> Properties
        {
            get
            {
                if (properties == null)
                {
                    properties = CreateReadOnlyCollection(declaration => declaration.Properties);
                }

                return properties;
            }
        }

        public IReadOnlyCollection<MethodNode> Methods
        {
            get
            {
                if (methods == null)
                {
                    methods = CreateReadOnlyCollection(declaration => declaration.Methods);
                }

                return methods;
            }
        }

        public override string ToString()
        {
            return Declarations[0].ToString();
        }

        protected IReadOnlyCollection<T> CreateReadOnlyCollection<T>(
            Func<TDeclarationNode, IReadOnlyCollection<T>> selectFunc)
        {
            return new ReadOnlyAggregateCollection<T, TDeclarationNode>(Declarations, selectFunc);
        }
    }
}
