using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface ISolution<TProject>
    {
        IReadOnlyCollection<TProject> Projects { get; }
    }
}
