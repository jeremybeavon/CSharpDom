using System;
using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal class PropertyNodeWithLinqExpressions : PropertyNodeWithReflection, IPropertyWithLinqExpressions
    {
        public PropertyNodeWithLinqExpressions(
            PropertyDeclarationSyntax declaration,
            IBasicMemberContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public IPropertyWithReflection Reflection
        {
            get { return this; }
        }

        IBasicTypeWithLinqExpressions IHasDeclaringType<IBasicTypeWithLinqExpressions>.DeclaringType
        {
            get { return (IBasicTypeWithLinqExpressions)DeclaringType; }
        }

        public void Accept(ILinqExpressionsVisitor visitor)
        {
            Accept(new LinqExpressionsNodeVisitor(visitor));
        }
    }
}
