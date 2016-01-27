using System.Reflection;

namespace CSharpDom.Reflection
{
    public interface IHasEventInfo
    {
        EventInfo EventInfo { get; }
    }
}
