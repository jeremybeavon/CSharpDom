using System;
using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface INamespaceWrapper :
        INamespace<IUsingDirectiveWrapper, INamespaceWrapper, IClassCollectionWrapper, IDelegateWrapper, IEnumWrapper, IInterfaceWrapper, IStructCollectionWrapper>
    {
    }
}
