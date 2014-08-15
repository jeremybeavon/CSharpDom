using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace CSharpDom.Common
{
    public interface ISolution<TProject>
    {
        Solution Solution { get; }

        IReadOnlyCollection<TProject> Projects { get; }
    }
}
