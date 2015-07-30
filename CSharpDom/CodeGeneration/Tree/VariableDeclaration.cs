using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class VariableDeclaration : CodeGenerationNode
    {
        public string Name { get; set; }

        public IExpressionStatement InitialValue { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            InitialValue.AcceptIfNotNull(visitor);
        }
    }
}
