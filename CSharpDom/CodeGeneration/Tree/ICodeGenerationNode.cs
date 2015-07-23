using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public interface ICodeGenerationNode
    {
        void Accept(CodeGenerationVisitor visitor);
    }
}
