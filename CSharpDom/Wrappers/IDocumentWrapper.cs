using System;
using System.Threading.Tasks;
using CSharpDom.Common;

namespace CSharpDom.Wrappers
{
    public interface IDocumentWrapper :
        IDocument<IProjectWrapper, ISolutionWrapper, ILoadedDocumentWrapper>
    {
    }
}
