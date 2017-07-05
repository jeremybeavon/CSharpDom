namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedSealedClassWithGenericParameterGenericParameterConstraint
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
