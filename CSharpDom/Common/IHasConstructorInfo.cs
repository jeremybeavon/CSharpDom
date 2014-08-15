using System.Reflection;

namespace CSharpDom.Common
{
    public interface IHasConstructorInfo
    {
        ConstructorInfo ConstructorInfo { get; }
    }
}
