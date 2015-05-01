using System;
using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal class EnumMemberNodeWithLinqExpressions : EnumMemberNodeWithReflection, IEnumMemberWithLinqExpressions,
        INestedEnumMemberWithLinqExpressions
    {
        public EnumMemberNodeWithLinqExpressions(
            EnumMemberDeclarationSyntax declaration,
            EnumNode container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        INestedEnumWithLinqExpressions IHasDeclaringType<INestedEnumWithLinqExpressions>.DeclaringType
        {
            get { return (INestedEnumWithLinqExpressions)DeclaringType; }
        }

        IEnumWithLinqExpressions IHasDeclaringType<IEnumWithLinqExpressions>.DeclaringType
        {
            get { return (IEnumWithLinqExpressions)DeclaringType; }
        }

        public void Accept(ILinqExpressionsVisitor visitor)
        {
            Accept(new LinqExpressionsNodeVisitor(visitor));
        }
    }
}
