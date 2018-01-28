using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal static class ListFactory
    {
        public static IChildSyntaxList<TParentSyntax, TChildSyntax> CreateChildSyntaxList<
            TParentNode,
            TParentSyntax,
            TChildList,
            TChildSyntax>(
            Node<TParentNode, TParentSyntax> node,
            IImmutableList<TChildList, TChildSyntax> immutableList,
            Func<TParentSyntax, TChildList> getList,
            Func<TParentSyntax, TChildList, TParentSyntax> createList)
            where TParentSyntax : class
            where TChildList : IReadOnlyList<TChildSyntax>
        {
            return new ChildSyntaxList<TParentNode, TParentSyntax, TChildList, TChildSyntax>(
                node,
                immutableList,
                getList,
                createList);
        }

        public static IChildSyntaxList<TParentSyntax, TChildSyntax> CreateChildSyntaxList<
            TParentNode,
            TParentSyntax,
            TChildSyntax>(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList)
            where TParentSyntax : class
            where TChildSyntax : SyntaxNode
        {
            return CreateChildSyntaxList(node, new ImmutableSyntaxList<TChildSyntax>(), getList, createList);
        }

        public static IChildSyntaxList<TParentSyntax, TChildSyntax> CreateChildSyntaxList<
            TParentNode,
            TParentSyntax,
            TChildSyntax>(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>, TParentSyntax> createList)
            where TParentSyntax : class
            where TChildSyntax : SyntaxNode
        {
            return CreateChildSyntaxList(node, new ImmutableSeparatedSyntaxList<TChildSyntax>(), getList, createList);
        }
        
        public static IList<GenericParameterDeclarationSyntax> CreateList<TParentNode, TParentSyntax>(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, TypeParameterListSyntax> getTypeParameters,
            Func<TParentSyntax, TypeParameterListSyntax, TParentSyntax> createTypeParameters,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> getConstraintClauses,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>, TParentSyntax> createConstraintClauses)
            where TParentSyntax : class
        {
            return new GenericParameterDeclarationList<TParentNode, TParentSyntax>(
                node,
                syntax => getTypeParameters(syntax)?.Parameters ?? SyntaxFactory.SeparatedList<TypeParameterSyntax>(),
                (parentSyntax, childSyntax) => createTypeParameters(parentSyntax, (getTypeParameters(parentSyntax) ?? SyntaxFactory.TypeParameterList()).WithParameters(childSyntax)),
                getConstraintClauses,
                createConstraintClauses);
        }

        public static SyntaxListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax> CreateList<
            TParentNode,
            TParentSyntax,
            TChildNode,
            TChildSyntax>(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TChildSyntax, TChildNode> factory)
            where TParentNode : class, IHasSyntax<TParentSyntax>
            where TParentSyntax : class
            where TChildNode : class, IHasNode<TChildSyntax>
            where TChildSyntax : SyntaxNode
        {
            return new SyntaxListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax>(node, getList, createList, factory);
        }

        public static SeparatedSyntaxListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax> CreateList<
            TParentNode,
            TParentSyntax,
            TChildNode,
            TChildSyntax>(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TChildSyntax, TChildNode> factory)
            where TParentNode : class, IHasSyntax<TParentSyntax>
            where TParentSyntax : class
            where TChildNode : class, IHasNode<TChildSyntax>
            where TChildSyntax : SyntaxNode
        {
            return new SeparatedSyntaxListWrapper<TParentNode, TParentSyntax, TChildNode, TChildSyntax>(
                node,
                getList,
                createList,
                factory);
        }

        public static IList<NameSyntax> CreateBaseTypeList<TParentNode, TParentSyntax>(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, BaseListSyntax, TParentSyntax> createList)
            where TParentSyntax : TypeDeclarationSyntax
        {
            return new BaseTypeList<TParentNode, TParentSyntax>(
                node,
                syntax => syntax?.BaseList?.Types ?? SyntaxFactory.SeparatedList<BaseTypeSyntax>(),
                (parentSyntax, childSyntax) => createList(parentSyntax, (parentSyntax.BaseList ?? SyntaxFactory.BaseList()).WithTypes(childSyntax)));
        }

        public static IList<TChildSyntax> CreateFilteredList<TParentNode, TParentSyntax, TChildBaseSyntax, TChildSyntax>(
            Node<TParentNode, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildBaseSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildBaseSyntax>, TParentSyntax> createList,
            Func<TChildSyntax, bool> filter)
            where TParentSyntax : class
            where TChildBaseSyntax : SyntaxNode
            where TChildSyntax : TChildBaseSyntax
        {
            return new FilteredList<TChildBaseSyntax, TChildSyntax>(CreateChildSyntaxList(node, getList, createList), filter);
        }

        public static IList<TChild> CreateFilteredList<TParent, TChild>(IList<TParent> list, Func<TChild, bool> filter)
            where TChild : class, TParent
        {
            return new FilteredList<TParent, TChild>(list, filter);
        }

        public static IList<TChildNode> CreateChildSyntaxList<TParentNode, TParentSyntax, TChildNode, TChildSyntax>(
            Node<TParentNode, TParentSyntax> node,
            IChildSyntaxList<TParentSyntax, TChildSyntax> list,
            Func<TChildNode> factory)
            where TParentNode : class, IHasSyntax<TParentSyntax>
            where TParentSyntax : class
            where TChildNode : class, IHasNode<TChildSyntax>
            where TChildSyntax : class
        {
            return new ChildNodeList<TParentNode, TParentSyntax, TChildNode, TChildSyntax>(node, list, factory);
        }

        public static IList<TChildNode> CreateConstraintList<TChildNode>(
            Node<GenericParameterDeclarationWithCodeAnalysis, GenericParameterDeclarationSyntax> node,
            Func<string, bool> filter,
            Func<UnspecifiedTypeReferenceWithCodeAnalysis, TChildNode> getChild)
            where TChildNode : class, IHasNode<TypeSyntax>
        {
            IList<TypeParameterConstraintSyntax> constraintSyntaxList = CreateChildSyntaxList(
                node,
                syntax => syntax.Constraints,
                (parentSyntax, childSyntax) => parentSyntax.WithConstraints(childSyntax));
            IList<TypeConstraintSyntax> filteredConstraintSyntaxList =
                new FilteredList<TypeParameterConstraintSyntax, TypeConstraintSyntax>(
                    constraintSyntaxList,
                    syntax => filter(syntax.Type.ToName()));
            IList<GenericParameterConstraint> constraintList = CreateChildSyntaxList(
                node,
                filteredConstraintSyntaxList,
                () => new GenericParameterConstraint());
            return new WrappedList<GenericParameterConstraint, TChildNode>(
                constraintList,
                parent => getChild(parent.Type),
                child => child.Node.GetParentNode<GenericParameterConstraint>());
        }
    }
}
