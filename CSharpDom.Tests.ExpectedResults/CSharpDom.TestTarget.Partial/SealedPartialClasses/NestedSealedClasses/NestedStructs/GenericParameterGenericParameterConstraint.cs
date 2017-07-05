namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedStructs
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public sealed class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
