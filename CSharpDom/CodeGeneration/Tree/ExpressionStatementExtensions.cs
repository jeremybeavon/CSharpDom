using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public static class ExpressionStatementExtensions
    {
        public static void AcceptIfNotNull(this IExpressionStatement node, CodeGenerationVisitor visitor)
        {
            if (node != null)
            {
                node.Accept(visitor);
            }
        }
    }
}
