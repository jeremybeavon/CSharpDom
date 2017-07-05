namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedStaticClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
