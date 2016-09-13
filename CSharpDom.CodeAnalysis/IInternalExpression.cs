using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    internal interface IInternalExpression : IExpressionWithCodeAnalysis, IHasNode<ExpressionSyntax>
    {
    }
}
