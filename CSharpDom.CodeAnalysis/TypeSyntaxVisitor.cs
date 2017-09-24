using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;

namespace CSharpDom.CodeAnalysis
{
    internal sealed class TypeSyntaxVisitor : CSharpSyntaxVisitor<string>
    {
        public override string DefaultVisit(SyntaxNode node)
        {
            throw new NotSupportedException();
        }

        public override string VisitAliasQualifiedName(AliasQualifiedNameSyntax node)
        {
            return node.Name.Accept(this);
        }

        public override string VisitIdentifierName(IdentifierNameSyntax node)
        {
            return node.Identifier.Text;
        }

        public override string VisitGenericName(GenericNameSyntax node)
        {
            return node.Identifier.Text;
        }

        public override string VisitQualifiedName(QualifiedNameSyntax node)
        {
            return node.Right.Accept(this);
        }
    }
}
