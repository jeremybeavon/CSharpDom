using CSharpDom.Common;

namespace CSharpDom.Reflection
{
    public interface IBasicTypeWithReflection : 
        IBasicType<EventWithReflection, PropertyWithReflection, IndexerWithReflection, MethodWithReflection>
    {
    }
}
