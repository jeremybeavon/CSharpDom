namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedStaticClasses
{
    public struct StructWithNestedAbstractPartialClassWithNestedStaticPartialClassWithGenericParameterGenericParameterConstraint
    {
        public abstract partial class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
