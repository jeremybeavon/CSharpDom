namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
