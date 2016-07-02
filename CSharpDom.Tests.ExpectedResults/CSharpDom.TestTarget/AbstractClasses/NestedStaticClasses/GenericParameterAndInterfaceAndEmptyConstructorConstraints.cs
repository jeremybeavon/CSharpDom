namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
