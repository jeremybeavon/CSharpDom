using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IProjectWrapper :
        IProject<ISolutionWrapper, IDocumentWrapper, ILoadedProjectWrapper>
    {
    }
}
