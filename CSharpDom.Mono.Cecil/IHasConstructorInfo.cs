using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public interface IHasConstructorInfo
    {
        ConstructorInfo ConstructorInfo { get; }
    }
}
