namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedStructs
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedStructWithGenericParameterGenericParameterConstraint
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
