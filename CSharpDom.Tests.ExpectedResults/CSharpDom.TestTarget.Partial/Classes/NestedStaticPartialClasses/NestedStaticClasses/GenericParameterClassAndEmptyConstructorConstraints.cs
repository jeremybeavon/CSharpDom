namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedStaticClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static partial class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
