namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs
{
    public sealed class SealedClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public struct Struct<TKey, TValue>
            where TKey : TValue
        {
        }
    }
}
