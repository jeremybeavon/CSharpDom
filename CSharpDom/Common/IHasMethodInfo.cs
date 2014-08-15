using System.Reflection;

namespace CSharpDom.Common
{
    public interface IHasMethodInfo
    {
        MethodInfo MethodInfo { get; }
    }
}
