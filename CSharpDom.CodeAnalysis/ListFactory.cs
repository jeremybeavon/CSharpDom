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
            TParent,
            TParentSyntax,
            TChildList,
            TChildSyntax>(
            Node<TParent, TParentSyntax> node,
            IImmutableList<TChildList, TChildSyntax> immutableList,
            Func<TParentSyntax, TChildList> getList,
            Func<TParentSyntax, TChildList, TParentSyntax> createList)
            where TParentSyntax : class
            where TChildList : IReadOnlyList<TChildSyntax>
        {
            return new ChildSyntaxList<TParent, TParentSyntax, TChildList, TChildSyntax>(
                node,
                immutableList,
                getList,
                createList);
        }

        public static IChildSyntaxList<TParentSyntax, TChildSyntax> CreateChildSyntaxList<
            TParent,
            TParentSyntax,
            TChildSyntax>(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList)
            where TParentSyntax : class
            where TChildSyntax : SyntaxNode
        {
            return CreateChildSyntaxList(node, new ImmutableSyntaxList<TChildSyntax>(), getList, createList);
        }

        public static IChildSyntaxList<TParentSyntax, TChildSyntax> CreateChildSyntaxList<
            TParent,
            TParentSyntax,
            TChildSyntax>(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>, TParentSyntax> createList)
            where TParentSyntax : class
            where TChildSyntax : SyntaxNode
        {
            return CreateChildSyntaxList(node, new ImmutableSeparatedSyntaxList<TChildSyntax>(), getList, createList);
        }
        
        public static IChildSyntaxList<TParentSyntax, GenericParameterDeclarationSyntax> CreateList<
            TParent,
            TParentSyntax>(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, TypeParameterListSyntax> getTypeParameters,
            Func<TParentSyntax, TypeParameterListSyntax, TParentSyntax> createTypeParameters,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>> getConstraintClauses,
            Func<TParentSyntax, SyntaxList<TypeParameterConstraintClauseSyntax>, TParentSyntax> createConstraintClauses)
            where TParentSyntax : class
        {
            return new GenericParameterDeclarationList<TParent, TParentSyntax>(
                node,
                syntax => getTypeParameters(syntax)?.Parameters ?? SyntaxFactory.SeparatedList<TypeParameterSyntax>(),
                (parentSyntax, childSyntax) => createTypeParameters(parentSyntax, (getTypeParameters(parentSyntax) ?? SyntaxFactory.TypeParameterList()).WithParameters(childSyntax)),
                getConstraintClauses,
                createConstraintClauses);
        }

        public static SyntaxNodeList<TParent, TParentSyntax, TChild, TChildSyntax> CreateList<
            TParent,
            TParentSyntax,
            TChild,
            TChildSyntax>(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TChildSyntax, TChild> factory)
            where TParent : class, IHasNode<TParentSyntax>
            where TParentSyntax : class
            where TChild : class, IHasNode<TChildSyntax>
            where TChildSyntax : SyntaxNode
        {
            return new SyntaxNodeList<TParent, TParentSyntax, TChild, TChildSyntax>(node, getList, createList, factory);
        }

        public static SeparatedSyntaxNodeList<TParent, TParentSyntax, TChild, TChildSyntax> CreateList<
            TParent,
            TParentSyntax,
            TChild,
            TChildSyntax>(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>> getList,
            Func<TParentSyntax, SeparatedSyntaxList<TChildSyntax>, TParentSyntax> createList,
            Func<TChildSyntax, TChild> factory)
            where TParent : class, IHasNode<TParentSyntax>
            where TParentSyntax : class
            where TChild : class, IHasNode<TChildSyntax>
            where TChildSyntax : SyntaxNode
        {
            return new SeparatedSyntaxNodeList<TParent, TParentSyntax, TChild, TChildSyntax>(
                node,
                getList,
                createList,
                factory);
        }

        public static IChildSyntaxList<TParentSyntax, NameSyntax> CreateBaseTypeList<TParent, TParentSyntax>(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, BaseListSyntax, TParentSyntax> createList)
            where TParentSyntax : TypeDeclarationSyntax
        {
            return new BaseTypeList<TParent, TParentSyntax>(
                node,
                syntax => syntax?.BaseList?.Types ?? SyntaxFactory.SeparatedList<BaseTypeSyntax>(),
                (parentSyntax, childSyntax) => createList(parentSyntax, (parentSyntax.BaseList ?? SyntaxFactory.BaseList()).WithTypes(childSyntax)));
        }

        public static IChildSyntaxList<TParentSyntax, TChildSyntax> CreateFilteredList<
            TParent,
            TParentSyntax,
            TChildBaseSyntax,
            TChildSyntax>(
            Node<TParent, TParentSyntax> node,
            Func<TParentSyntax, SyntaxList<TChildBaseSyntax>> getList,
            Func<TParentSyntax, SyntaxList<TChildBaseSyntax>, TParentSyntax> createList,
            Func<TChildSyntax, bool> filter)
            where TParentSyntax : class
            where TChildBaseSyntax : SyntaxNode
            where TChildSyntax : TChildBaseSyntax
        {
            return new FilteredChildSyntaxList<TParentSyntax, TChildBaseSyntax, TChildSyntax>(
                CreateChildSyntaxList(node, getList, createList),
                filter);
        }

        public static IList<TChild> CreateFilteredList<TParent, TChild>(IList<TParent> list, Func<TChild, bool> filter)
            where TChild : class, TParent
        {
            return new FilteredList<TParent, TChild>(list, filter);
        }

        public static IList<TChild> CreateChildSyntaxList<TParent, TParentSyntax, TChild, TChildSyntax>(
            Node<TParent, TParentSyntax> node,
            IChildSyntaxList<TParentSyntax, TChildSyntax> list,
            Func<TChild> factory)
            where TParent : class, IHasNode<TParentSyntax>
            where TParentSyntax : class
            where TChild : class, IHasNode<TChildSyntax>
            where TChildSyntax : class
        {
            return new ChildNodeList<TParent, TParentSyntax, TChild, TChildSyntax>(node, list, factory);
        }

        public static IList<TChild> CreateConstraintList<TChild>(
            Node<GenericParameterDeclarationWithCodeAnalysis, GenericParameterDeclarationSyntax> node,
            Func<string, bool> filter,
            Func<UnspecifiedTypeReferenceWithCodeAnalysis, TChild> getChild)
            where TChild : class, IHasNode<TypeSyntax>
        {
            IChildSyntaxList<GenericParameterDeclarationSyntax, TypeParameterConstraintSyntax> constraintSyntaxList =
                CreateChildSyntaxList(
                    node,
                    syntax => syntax.Constraints,
                    (parentSyntax, childSyntax) => parentSyntax.WithConstraints(childSyntax));
            IChildSyntaxList<GenericParameterDeclarationSyntax, TypeConstraintSyntax> filteredConstraintSyntaxList =
                new FilteredChildSyntaxList<GenericParameterDeclarationSyntax, TypeParameterConstraintSyntax, TypeConstraintSyntax>(
                    constraintSyntaxList,
                    syntax => filter(syntax.Type.ToName()));
            IList<GenericParameterConstraint> constraintList = CreateChildSyntaxList(
                node,
                filteredConstraintSyntaxList,
                () => new GenericParameterConstraint());
            return new WrappedList<GenericParameterConstraint, TChild>(
                constraintList,
                parent => getChild(parent.Type),
                child => child.Node.GetParent<GenericParameterConstraint>());
        }
    }
}
