namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
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
