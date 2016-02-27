using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public interface IHasAssembly
    {
        Assembly Assembly { get; }
    }
}
