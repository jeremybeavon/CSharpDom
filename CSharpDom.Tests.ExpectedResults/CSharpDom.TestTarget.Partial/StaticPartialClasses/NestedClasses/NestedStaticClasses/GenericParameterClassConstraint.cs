namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
