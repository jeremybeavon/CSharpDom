namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticClasses
{
    public class ClassWithNestedStaticPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, new()
        {
        }
    }
}
