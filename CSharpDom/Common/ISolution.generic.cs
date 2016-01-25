using System.Collections.Generic;

namespace CSharpDom.Common
{
    public interface ISolution<TProject> : ISolution
        where TProject : IProject
    {
        IReadOnlyCollection<TProject> Projects { get; }
    }
}
