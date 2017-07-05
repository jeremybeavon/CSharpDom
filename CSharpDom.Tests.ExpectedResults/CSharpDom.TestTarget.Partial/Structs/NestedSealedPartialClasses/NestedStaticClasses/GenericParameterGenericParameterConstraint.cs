namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedStaticClasses
{
    public struct StructWithNestedSealedPartialClassWithNestedStaticPartialClassWithGenericParameterGenericParameterConstraint
    {
        public sealed partial class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
