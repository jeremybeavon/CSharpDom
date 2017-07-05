namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedClassWithGenericParameterGenericParameterConstraint
    {
        public static class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
