namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.NestedStaticClasses
{
    public class ClassWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
