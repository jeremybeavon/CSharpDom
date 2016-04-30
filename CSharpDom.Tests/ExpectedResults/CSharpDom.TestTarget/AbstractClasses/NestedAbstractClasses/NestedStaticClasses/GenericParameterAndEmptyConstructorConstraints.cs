namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
