using System;
using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal class OperatorOverloadNodeWithLinqExpressions : OperatorOverloadNodeWithReflection,
        IOperatorOverloadWithLinqExpressions
    {
        public OperatorOverloadNodeWithLinqExpressions(
            OperatorDeclarationSyntax declaration,
            IMemberContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public IOperatorOverloadWithReflection Reflection
        {
            get { return this; }
        }

        ITypeWithLinqExpressions IHasDeclaringType<ITypeWithLinqExpressions>.DeclaringType
        {
            get { return (ITypeWithLinqExpressions)DeclaringType; }
        }
    }
}
