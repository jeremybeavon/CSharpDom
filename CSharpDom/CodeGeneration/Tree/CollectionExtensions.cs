using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    internal static class CollectionExtensions
    {
        public static void AcceptIfNotNull<T>(this Collection<T> collection, CodeGenerationVisitor visitor)
            where T : CodeGenerationNode
        {
            if (collection != null)
            {
                foreach (T node in collection)
                {
                    node.Accept(visitor);
                }
            }
        }
    }
}
