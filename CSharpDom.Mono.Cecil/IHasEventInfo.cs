using System.Reflection;

namespace CSharpDom.Mono.Cecil
{
    public interface IHasEventInfo
    {
        EventInfo EventInfo { get; }
    }
}
