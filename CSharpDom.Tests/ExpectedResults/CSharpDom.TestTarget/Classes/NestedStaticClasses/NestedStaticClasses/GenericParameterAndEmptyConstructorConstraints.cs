namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedStaticClasses
{
    public class ClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
