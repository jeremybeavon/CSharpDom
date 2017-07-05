namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedSealedClasses
{
    public sealed class SealedClassWithNestedStructWithNestedSealedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public sealed class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
