namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedClasses
{
    public static class StaticClassWithNestedStaticClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints
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
