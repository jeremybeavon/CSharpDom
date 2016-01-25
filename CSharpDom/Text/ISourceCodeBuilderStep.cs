using System.Text;

namespace CSharpDom.Text
{
    public interface ISourceCodeBuilderStep
    {
        void AddText(SourceCodeTextBuilder builder);
    }
}
