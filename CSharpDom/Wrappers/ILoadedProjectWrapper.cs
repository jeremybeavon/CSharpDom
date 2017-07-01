using System.Collections.Generic;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface ILoadedProjectWrapper :
        ILoadedProject<ISolutionWrapper, IProjectWrapper, INamespaceWrapper, IClassCollectionWrapper, IDelegateWrapper, IEnumWrapper, IInterfaceWrapper, IStructCollectionWrapper>
    {
    }
}
