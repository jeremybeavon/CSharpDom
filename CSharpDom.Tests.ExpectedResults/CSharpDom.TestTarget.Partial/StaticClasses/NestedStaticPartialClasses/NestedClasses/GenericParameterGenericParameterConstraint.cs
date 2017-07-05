namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
