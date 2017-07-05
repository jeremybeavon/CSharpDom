namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedStaticClasses
{
    public struct StructWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterGenericParameterConstraint
    {
        public partial class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
