using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassReference : CodeGenerationNode
    {
        public ClassReference(Type type)
        {
        }

        public ClassReference(Class @class)
        {
        }

        public ClassReference(string type)
        {
        }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
        }
    }
}
