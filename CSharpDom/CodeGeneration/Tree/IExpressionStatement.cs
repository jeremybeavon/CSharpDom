using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public interface IExpressionStatement
    {
        void Accept(CodeGenerationVisitor visitor);
    }
}
