using CSharpDom.Common;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    internal interface ITypeModifier<TType> : IMemberModifier<TType>, IHasNamespace<NamespaceNode>
    {
        bool IsNestedType { get; }

        TType WithMembers(TType type, SyntaxList<MemberDeclarationSyntax> members);

        TType WithBaseList(TType type, BaseListSyntax baseList);

        TType WithConstraintClauses(TType type, SyntaxList<TypeParameterConstraintClauseSyntax> constraintClauses);
    }
}
