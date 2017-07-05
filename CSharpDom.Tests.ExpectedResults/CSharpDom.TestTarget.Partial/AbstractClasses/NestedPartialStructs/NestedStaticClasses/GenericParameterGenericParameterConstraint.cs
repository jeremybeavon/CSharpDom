namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStructWithNestedStaticPartialClassWithGenericParameterGenericParameterConstraint
    {
        public struct Struct
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
