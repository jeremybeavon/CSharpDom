using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal sealed partial class LinqBuilder
    {
        public override ILinqExpressionMapping VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            foreach (ParameterSyntax parameter in node.ParameterList.Parameters)
            {
                Type type = typeResolver.GetType(parameter.Type);
            }

            BlockStatement body = (BlockStatement)node.Body.Accept(this);
            return new MemberImplementation<MethodDeclarationSyntax>(Expression.Lambda(body.Expressions.Single()), node, body);
        }
    }
}
