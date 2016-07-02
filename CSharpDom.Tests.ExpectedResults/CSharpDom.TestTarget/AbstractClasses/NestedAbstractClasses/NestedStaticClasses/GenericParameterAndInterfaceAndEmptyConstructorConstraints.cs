namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
