using System.Reflection;

namespace CSharpDom.Reflection
{
    public interface IHasFieldInfo
    {
        FieldInfo FieldInfo { get; }
    }
}
