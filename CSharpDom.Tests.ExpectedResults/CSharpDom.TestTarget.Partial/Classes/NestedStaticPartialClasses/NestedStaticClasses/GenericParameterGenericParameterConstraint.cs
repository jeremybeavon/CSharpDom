namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedStaticClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterGenericParameterConstraint
    {
        public static partial class Class
        {
            public static class NestedClass<TKey, TValue>
                where TKey : TValue
            {
            }
        }
    }
}
