using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class VariableDeclarationStatement : Statement
    {
        public bool IsConst { get; set; }

        public TypeReference Type { get; set; }

        public string Name { get; set; }

        public IExpressionStatement InitialValue { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
            Type.AcceptIfNotNull(visitor);
            InitialValue.AcceptIfNotNull(visitor);
        }
    }
}
