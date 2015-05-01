using System;
using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal class DestructorNodeWithLinqExpressions : DestructorNodeWithReflection, IDestructorWithLinqExpressions
    {
        public DestructorNodeWithLinqExpressions(
            DestructorDeclarationSyntax declaration,
            ClassDeclarationNode container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
        }

        public IDestructorWithReflection Reflection
        {
            get { return this; }
        }

        IClassDeclarationWithLinqExpressions IHasDeclaringType<IClassDeclarationWithLinqExpressions>.DeclaringType
        {
            get { return (IClassDeclarationWithLinqExpressions)DeclaringType; }
        }

        public void Accept(ILinqExpressionsVisitor visitor)
        {
            Accept(new LinqExpressionsNodeVisitor(visitor));
        }
    }
}
