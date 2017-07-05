namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
