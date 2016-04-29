namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.NestedClasses
{
    public class ClassWithNestedStaticClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
