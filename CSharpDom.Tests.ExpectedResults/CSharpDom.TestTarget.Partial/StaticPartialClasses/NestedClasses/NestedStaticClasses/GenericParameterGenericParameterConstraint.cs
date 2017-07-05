namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint
    {
        public class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
