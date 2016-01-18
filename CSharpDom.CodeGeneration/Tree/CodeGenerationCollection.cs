using System.Collections.ObjectModel;

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
