namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedInterfaces
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
