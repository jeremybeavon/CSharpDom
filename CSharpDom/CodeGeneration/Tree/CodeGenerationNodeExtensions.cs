using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public static class CodeGenerationNodeExtensions
    {
        public static void AcceptIfNotNull(this CodeGenerationNode node, CodeGenerationVisitor visitor)
        {
            if (node != null)
            {
                node.Accept(visitor);
            }
        }
    }
}
