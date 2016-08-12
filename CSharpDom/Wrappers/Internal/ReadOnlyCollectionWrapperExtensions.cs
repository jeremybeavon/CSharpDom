using CSharpDom.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Wrappers.Internal
{
    internal static class ReadOnlyCollectionWrapperExtensions
    {
        public static Func<IReadOnlyCollection<IAttributeGroupWrapper>> WrapAttributes<TInput>(this IReadOnlyCollection<TInput> input)
            where TInput : IAttributeGroup
        {
            return () => new ReadOnlyCollectionWrapper<TInput, IAttributeGroupWrapper>(
                input,
                element => new AttributeGroupWrapper(element));
        }
    }
}
