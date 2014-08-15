using Microsoft.CodeAnalysis;

namespace CSharpDom.Common
{
    public interface IDocument
    {
        string FullFilePath { get; }

        Document Document { get; }
    }
}
