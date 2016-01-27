using System.Reflection;

namespace CSharpDom.Reflection
{
    public interface IHasParameterInfo
    {
        ParameterInfo ParameterInfo { get; }
    }
}
