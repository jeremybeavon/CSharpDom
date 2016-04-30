namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
