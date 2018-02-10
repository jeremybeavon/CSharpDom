using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class TypeParameterSyntaxListConversions<TParentSyntax> :
        IChildSyntaxListConversions<TParentSyntax, SeparatedSyntaxList<TypeParameterSyntax>>
    {
        private readonly Func<TParentSyntax, TypeParameterListSyntax> getTypeParameters;
        private readonly Func<TParentSyntax, TypeParameterListSyntax, TParentSyntax> createTypeParameters;

        public TypeParameterSyntaxListConversions(
            Func<TParentSyntax, TypeParameterListSyntax> getTypeParameters,
            Func<TParentSyntax, TypeParameterListSyntax, TParentSyntax> createTypeParameters)
        {
            this.getTypeParameters = getTypeParameters;
            this.createTypeParameters = createTypeParameters;
        }

        public TParentSyntax CreateList(
            TParentSyntax parentSyntax,
            SeparatedSyntaxList<TypeParameterSyntax> childSyntax)
        {
            return createTypeParameters(
                parentSyntax,
                (getTypeParameters(parentSyntax) ?? SyntaxFactory.TypeParameterList()).WithParameters(childSyntax));
        }

        public SeparatedSyntaxList<TypeParameterSyntax> GetList(TParentSyntax syntax)
        {
            return getTypeParameters(syntax)?.Parameters ?? SyntaxFactory.SeparatedList<TypeParameterSyntax>();
        }
    }
}
