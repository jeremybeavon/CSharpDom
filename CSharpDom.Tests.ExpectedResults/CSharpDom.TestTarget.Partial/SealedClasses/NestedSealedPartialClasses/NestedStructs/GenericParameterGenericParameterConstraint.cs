namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedStructs
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public sealed partial class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
