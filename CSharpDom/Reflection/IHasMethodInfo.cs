using System.Reflection;

namespace CSharpDom.Reflection
{
    public interface IHasMethodInfo
    {
        MethodInfo MethodInfo { get; }
    }
}
