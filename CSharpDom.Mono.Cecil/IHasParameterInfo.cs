using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public interface IHasParameterInfo
    {
        ParameterInfo ParameterInfo { get; }
    }
}
