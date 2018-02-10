using CSharpDom.Common;
using CSharpDom.Text.Steps;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Text
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<ISourceCodeBuilderStep> ToSteps<TChildNode>(this IEnumerable<TChildNode> enumerable)
            where TChildNode : IVisitable<IGenericVisitor>
        {
            return enumerable.Select(item => new WriteChildNode<TChildNode>(item));
        }
    }
}
