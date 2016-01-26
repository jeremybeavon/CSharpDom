using System.Reflection;

namespace CSharpDom.Reflection
{
    public interface IHasConstructorInfo
    {
        ConstructorInfo ConstructorInfo { get; }
    }
}
