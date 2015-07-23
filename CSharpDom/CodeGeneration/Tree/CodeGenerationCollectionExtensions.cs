using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public static class CodeGenerationCollectionExtensions
    {
        public static void AcceptIfNotNull<T>(this CodeGenerationCollection<T> collection, CodeGenerationVisitor visitor)
            where T : CodeGenerationNode
        {
            if (collection != null)
            {
                collection.Accept(visitor);
            }
        }
    }
}
