using System.Reflection;

namespace CSharpDom.Reflection
{
    public interface IHasAssembly
    {
        Assembly Assembly { get; }
    }
}
