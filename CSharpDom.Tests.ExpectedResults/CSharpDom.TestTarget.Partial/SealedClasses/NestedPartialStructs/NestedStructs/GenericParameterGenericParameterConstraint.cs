namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedStructs
{
    public sealed class SealedClassWithNestedStructWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
