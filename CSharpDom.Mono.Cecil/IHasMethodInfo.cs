using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public interface IHasMethodInfo
    {
        MethodInfo MethodInfo { get; }
    }
}
