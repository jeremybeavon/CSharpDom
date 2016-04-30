namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
