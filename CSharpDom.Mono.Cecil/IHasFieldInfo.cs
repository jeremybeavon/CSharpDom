using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public interface IHasFieldInfo
    {
        FieldInfo FieldInfo { get; }
    }
}
