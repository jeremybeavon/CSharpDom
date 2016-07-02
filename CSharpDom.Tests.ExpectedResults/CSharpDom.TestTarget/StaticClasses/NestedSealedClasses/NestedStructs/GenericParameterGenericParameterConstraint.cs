namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedStructs
{
    public static class StaticClassWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraint
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
