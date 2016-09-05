using System;
using System.Collections.Generic;
using System.Linq;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;

namespace CSharpDom.CodeAnalysis
{
    public sealed class IndexerWithCodeAnalysis :
        EditableIndexer<
            AttributeGroupWithCodeAnalysis,
            IBasicType,
            ITypeReferenceWithCodeAnalysis,
            IndexerParameterWithCodeAnalysis,
            AccessorWithCodeAnalysis>,
        IHasSyntax<IndexerDeclarationSyntax>,
        ISimpleMember
    {
        private readonly object indexer;
        private readonly Node<IndexerWithCodeAnalysis, IndexerDeclarationSyntax> node;
        private readonly AttributeListWrapper<IndexerWithCodeAnalysis, IndexerDeclarationSyntax> attributes;
        private readonly CachedChildNode<
            IndexerWithCodeAnalysis,
            IndexerDeclarationSyntax,
            AccessorWithCodeAnalysis,
            AccessorDeclarationSyntax> getAccessor;
        private readonly CachedChildNode<
            IndexerWithCodeAnalysis,
            IndexerDeclarationSyntax,
            ITypeReferenceWithCodeAnalysis,
            TypeSyntax> indexerType;
        private readonly SeparatedSyntaxListWrapper<
            IndexerWithCodeAnalysis,
            IndexerDeclarationSyntax,
            IndexerParameterWithCodeAnalysis,
            ParameterSyntax> parameters;
        private readonly CachedChildNode<
            IndexerWithCodeAnalysis,
            IndexerDeclarationSyntax,
            AccessorWithCodeAnalysis,
            AccessorDeclarationSyntax> setAccessor;

        internal IndexerWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, AbstractIndexerWithCodeAnalysis indexer)
            : this(indexer)
        {
            AbstractClassParent = parent;
        }

        internal IndexerWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ClassIndexerWithCodeAnalysis indexer, ClassType classType)
            : this(indexer)
        {
            SetClassParent(parent, classType);
        }

        internal IndexerWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, SealedClassIndexerWithCodeAnalysis indexer)
            : this(indexer)
        {
            SealedClassParent = parent;
        }

        internal IndexerWithCodeAnalysis(ClassTypeWithCodeAnalysis parent, ExplicitInterfaceIndexerWithCodeAnalysis indexer)
            : this(indexer)
        {
            ExplicitInterfaceClassParent = parent;
        }

        internal IndexerWithCodeAnalysis(InterfaceTypeWithCodeAnalysis parent, InterfaceIndexerWithCodeAnalysis indexer)
            : this(indexer)
        {
            InterfaceParent = parent;
        }

        private IndexerWithCodeAnalysis(object indexer)
        {
            node = new Node<IndexerWithCodeAnalysis, IndexerDeclarationSyntax>(this);
            this.indexer = indexer;
            attributes = new AttributeListWrapper<IndexerWithCodeAnalysis, IndexerDeclarationSyntax>(
                node,
                syntax => syntax.AttributeLists,
                (parentSyntax, childSyntax) => parentSyntax.WithAttributeLists(childSyntax),
                parent => new AttributeGroupWithCodeAnalysis(parent),
                (child, parent) => child.IndexerParent = parent);
            getAccessor = GetAccessorNode(SyntaxKind.GetKeyword);
            indexerType = new CachedChildNode<IndexerWithCodeAnalysis, IndexerDeclarationSyntax, ITypeReferenceWithCodeAnalysis, TypeSyntax>(
                node,
                parent => parent.Syntax.Type.ToTypeReference(),
                null,
                null);
            parameters = new SeparatedSyntaxListWrapper<IndexerWithCodeAnalysis, IndexerDeclarationSyntax, IndexerParameterWithCodeAnalysis, ParameterSyntax>(
                node,
                syntax => syntax.ParameterList.Parameters,
                (parentSyntax, childSyntax) => parentSyntax.WithParameterList(parentSyntax.ParameterList.WithParameters(childSyntax)),
                parent => new IndexerParameterWithCodeAnalysis(parent),
                (child, parent) => child.Parameter.IndexerParent = parent);
            setAccessor = GetAccessorNode(SyntaxKind.SetKeyword);
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes; }
            set { attributes.ReplaceList(value); }
        }

        public override IBasicType DeclaringType
        {
            get { return node.GetParentNode<IBasicType>(); }
            set { throw new NotSupportedException(); }
        }

        public override AccessorWithCodeAnalysis GetAccessor
        {
            get { return getAccessor.Value; }
            set { getAccessor.Value = value; }
        }

        public override ITypeReferenceWithCodeAnalysis IndexerType
        {
            get { return indexerType.Value; }
            set { indexerType.Value = value; }
        }

        public override IList<IndexerParameterWithCodeAnalysis> Parameters
        {
            get { return parameters; }
            set
            {
                Syntax = Syntax.WithParameterList(
                    SyntaxFactory.BracketedParameterList(SyntaxFactory.SeparatedList(value.Select(node => node.Syntax))));
            }
        }

        public override AccessorWithCodeAnalysis SetAccessor
        {
            get { return setAccessor.Value; }
            set { setAccessor.Value = value; }
        }

        public IndexerDeclarationSyntax Syntax
        {
            get { return node.Syntax; }
            set { node.Syntax = value; }
        }

        internal IAttributeCollection AttributeList
        {
            get { return attributes; }
        }

        internal IChildCollection<IndexerParameterWithCodeAnalysis, ParameterSyntax> ParameterList
        {
            get { return parameters; }
        }

        internal Node<IndexerWithCodeAnalysis, IndexerDeclarationSyntax> Node
        {
            get { return node; }
        }

        internal ClassTypeWithCodeAnalysis AbstractClassParent
        {
            get { return node.GetParentNode<ClassTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.AbstractType.Indexers.AbstractIndexerList);
            }
        }

        internal ClassTypeWithCodeAnalysis ExplicitInterfaceClassParent
        {
            get { return node.GetParentNode<ClassTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.Indexers.ExplicitInterfaceIndexerList);
            }
        }
        
        internal InterfaceTypeWithCodeAnalysis InterfaceParent
        {
            get { return node.GetParentNode<InterfaceTypeWithCodeAnalysis>(); }
            set { node.SetParentNode<InterfaceTypeWithCodeAnalysis, InterfaceDeclarationSyntax>(value, parent => parent.IndexerList); }
        }

        internal ClassTypeWithCodeAnalysis SealedClassParent
        {
            get { return node.GetParentNode<ClassTypeWithCodeAnalysis>(); }
            set
            {
                node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                    value,
                    parent => parent.SealedType.Indexers.IndexerList);
            }
        }

        private CachedChildNode<IndexerWithCodeAnalysis, IndexerDeclarationSyntax, AccessorWithCodeAnalysis, AccessorDeclarationSyntax> GetAccessorNode(
            SyntaxKind kind)
        {
            return new CachedChildNode<IndexerWithCodeAnalysis, IndexerDeclarationSyntax, AccessorWithCodeAnalysis, AccessorDeclarationSyntax>(
                node,
                parent => GetAccessorDeclaration(parent.Syntax, kind) == null ? null : new AccessorWithCodeAnalysis(this, kind),
                (parentSyntax, childSyntax) => CreateAccessor(kind)(parentSyntax, childSyntax),
                (child, parent) => child.IndexerParent = parent);
        }

        internal static Func<IndexerDeclarationSyntax, AccessorDeclarationSyntax, IndexerDeclarationSyntax> CreateAccessor(
            SyntaxKind kind)
        {
            return (IndexerDeclarationSyntax parentSyntax, AccessorDeclarationSyntax childSyntax) =>
                parentSyntax.WithAccessorList(parentSyntax.AccessorList.WithAccessor(childSyntax, kind));
        }

        internal static AccessorDeclarationSyntax GetAccessorDeclaration(IndexerDeclarationSyntax syntax, SyntaxKind kind)
        {
            return syntax.AccessorList.GetAccessorDeclaration(kind);
        }

        internal void SetClassParent(ClassTypeWithCodeAnalysis value, ClassType classType)
        {
            switch (classType)
            {
                case ClassType.Normal:
                    node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                        value,
                        parent => parent.Indexers.IndexerList);
                    break;
                case ClassType.Abstract:
                    node.SetParentNode<ClassTypeWithCodeAnalysis, ClassDeclarationSyntax>(
                        value,
                        parent => parent.AbstractType.Indexers.IndexerList);
                    break;
            }
        }
        
        T ISimpleMember.Member<T>()
        {
            return (T)indexer;
        }
    }
}
