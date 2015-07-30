using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class VariableDeclarationStatement : Statement
    {
        public VariableDeclarationStatement()
        {
            VariableDeclarations = new CodeGenerationCollection<VariableDeclaration>();
        }

        public bool IsConst { get; set; }

        public TypeReference Type { get; set; }

        public CodeGenerationCollection<VariableDeclaration> VariableDeclarations { get; set; }

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
            VariableDeclarations.AcceptIfNotNull(visitor);
        }
    }
}
