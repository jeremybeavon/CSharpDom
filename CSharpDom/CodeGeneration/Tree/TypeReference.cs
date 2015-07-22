using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public class TypeReference : CodeGenerationNode
    {
        public TypeReference(Type type)
        {
        }

        public TypeReference(Class @class)
        {
        }

        public TypeReference(string type)
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
