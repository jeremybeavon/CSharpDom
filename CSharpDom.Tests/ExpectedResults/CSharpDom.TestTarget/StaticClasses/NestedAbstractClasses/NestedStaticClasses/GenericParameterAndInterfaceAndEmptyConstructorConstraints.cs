namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
