using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IEnumWrapper :
        IEnum<INamespaceWrapper, IDocumentWrapper, IProjectWrapper, ISolutionWrapper, IAttributeGroupWrapper, IEnumMemberWrapper>
    {
    }
}
