namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
