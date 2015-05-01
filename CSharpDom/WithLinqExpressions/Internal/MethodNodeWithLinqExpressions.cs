using System.Collections.Generic;
using System.Linq.Expressions;
using CSharpDom.Common;
using CSharpDom.WithReflection;
using CSharpDom.WithReflection.Internal;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal class MethodNodeWithLinqExpressions : MethodNodeWithReflection, IMethodWithLinqExpressions
    {
        private readonly SemanticModel semanticModel;
        private IImplementation implementation;
        
        public MethodNodeWithLinqExpressions(
            MethodDeclarationSyntax declaration,
            IBasicMemberContainer container,
            SemanticModel semanticModel)
            : base(declaration, container, semanticModel)
        {
            this.semanticModel = semanticModel;
        }

        public IMethodWithReflection Reflection
        {
            get { return this; }
        }

        public IImplementation Implementation
        {
            get { return implementation ?? (implementation = BuildMemberDeclaration()); }
        }

        IBasicTypeWithLinqExpressions IHasDeclaringType<IBasicTypeWithLinqExpressions>.DeclaringType
        {
            get { return (IBasicTypeWithLinqExpressions)DeclaringType; }
        }

        public void Accept(ILinqExpressionsVisitor visitor)
        {
            Accept(new LinqExpressionsNodeVisitor(visitor));
        }

        private IImplementation BuildMemberDeclaration()
        {
            return (IImplementation)Declaration.Accept(new LinqBuilder(semanticModel));
        }
    }
}
