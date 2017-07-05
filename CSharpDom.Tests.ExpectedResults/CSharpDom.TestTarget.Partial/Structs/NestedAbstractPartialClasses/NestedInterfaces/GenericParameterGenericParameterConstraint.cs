namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedInterfaces
{
    public struct StructWithNestedAbstractPartialClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public abstract partial class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
