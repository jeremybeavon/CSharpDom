namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedAbstractClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
