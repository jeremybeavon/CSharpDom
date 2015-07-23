using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public class CodeGenerationCollection<T> : Collection<T>, ICodeGenerationNode
        where T : CodeGenerationNode
    {
        public virtual void Accept(CodeGenerationVisitor visitor)
        {
            foreach (T node in this)
            {
                node.Accept(visitor);
            }
        }
    }
}
