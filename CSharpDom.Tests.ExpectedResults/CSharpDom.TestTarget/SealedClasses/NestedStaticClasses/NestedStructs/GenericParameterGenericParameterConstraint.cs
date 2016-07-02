namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedStructs
{
    public sealed class SealedClassWithNestedStaticClassWithNestedStructWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public struct NestedStruct<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
