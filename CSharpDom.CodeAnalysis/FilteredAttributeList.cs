using System;
using System.Collections.Generic;

namespace CSharpDom.CodeAnalysis
{
    internal class FilteredAttributeList :
        FilteredList<AttributeGroupWithCodeAnalysis, AttributeGroupWithCodeAnalysis>
    {
        public FilteredAttributeList(
            IList<AttributeGroupWithCodeAnalysis> attributes,
            Func<AttributeGroupWithCodeAnalysis, bool> filter)
            : base(attributes, filter)
        {
        }
    }
}
