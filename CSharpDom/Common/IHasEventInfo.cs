using System.Reflection;

namespace CSharpDom.Common
{
    public interface IHasEventInfo
    {
        EventInfo EventInfo { get; }
    }
}
