using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace CSharpDom.Common
{
    public interface IProject<TDocument>
    {
        Project Project { get; }

        IReadOnlyCollection<TDocument> Documents { get; }
    }
}
