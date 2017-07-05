namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedInterfaces
{
    public struct StructWithNestedStaticPartialClassWithNestedInterfaceWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public interface Interface<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
