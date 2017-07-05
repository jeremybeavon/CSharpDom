namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticPartialClasses.NestedSealedClasses
{
    public struct StructWithNestedStaticPartialClassWithNestedSealedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
