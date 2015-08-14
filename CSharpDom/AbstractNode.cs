using System;
using System.Collections.Generic;
using CSharpDom.WithSyntax;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SyntaxFactory = Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace CSharpDom
{
    internal abstract class AbstractNode
    {
        public virtual void Accept(NodeVisitor visitor)
        {
        }

        public abstract AbstractSyntaxNode CreateNode();

        public abstract override string ToString();

        protected static void VisitCollection<T>(IEnumerable<T> collection, Action<T> visitAction)
        {
            NodeVisitor.VisitCollection(collection, visitAction);
        }

        protected static string ToString<T>(string namespaceOrDeclaringType, IMemberModifier<T> modifier)
        {
            return ToPrefixedString(namespaceOrDeclaringType, ToModifiedString(modifier.Declaration, modifier));
        }

        protected static string ToString<T, TDeclaringType>(TDeclaringType declaringType, IMemberModifier<T> modifier)
        {
            return ToModifiedString(modifier.Declaration, modifier);
        }

        protected static string ToString<T, TDeclaringType>(TDeclaringType declaringType, IPropertyModifier<T> modifier)
            where T : BasePropertyDeclarationSyntax
        {
            SyntaxList<AccessorDeclarationSyntax> accessors = new SyntaxList<AccessorDeclarationSyntax>();
            foreach (AccessorDeclarationSyntax accessorDeclaration in modifier.Declaration.AccessorList.Accessors)
            {
                accessors.Add(accessorDeclaration.WithBody(SyntaxFactory.Block()));
            }

            T member = modifier.WithAccessors(modifier.Declaration, SyntaxFactory.AccessorList(accessors));
            return ToPrefixedString(declaringType.ToString(), ToModifiedString(member, modifier));
        }

        protected static string ToString<T, TDeclaringType>(TDeclaringType declaringType, IMethodModifier<T> modifier)
        {
            T member = modifier.WithBody(modifier.Declaration, SyntaxFactory.Block());
            return ToPrefixedString(declaringType.ToString(), ToModifiedString(member, modifier));
        }

        protected static string ToString<T, TDeclaringType>(TDeclaringType declaringType, ITypeModifier<T> modifier)
        {
            T member = modifier.WithMembers(modifier.Declaration, new SyntaxList<MemberDeclarationSyntax>());
            member = modifier.WithBaseList(member, SyntaxFactory.BaseList());
            member = modifier.WithConstraintClauses(member, new SyntaxList<TypeParameterConstraintClauseSyntax>());
            string prefix = modifier.IsNestedType ? declaringType.ToString() : modifier.Namespace.Name;
            return ToPrefixedString(prefix, ToModifiedString(member, modifier));
        }

        private static string ToPrefixedString(string prefix, string text)
        {
            return string.Format("{0}: {1}", prefix, text);
        }

        private static string ToModifiedString<T>(T member, IMemberModifier<T> modifier)
        {
            member = modifier.WithAttributeLists(member, new SyntaxList<AttributeListSyntax>());
            member = modifier.WithModifiers(member, new SyntaxTokenList());
            return member.ToString().Replace("\n", string.Empty).Replace("\r", string.Empty);
        }
    }
}
