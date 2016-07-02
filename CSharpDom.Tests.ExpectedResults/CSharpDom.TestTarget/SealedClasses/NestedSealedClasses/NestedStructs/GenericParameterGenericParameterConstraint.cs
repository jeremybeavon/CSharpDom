namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedStructs
{
    public sealed class SealedClassWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraint
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
