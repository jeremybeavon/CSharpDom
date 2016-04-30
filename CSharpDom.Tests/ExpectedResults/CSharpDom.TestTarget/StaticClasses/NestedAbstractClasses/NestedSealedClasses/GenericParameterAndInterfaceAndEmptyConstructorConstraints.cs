namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedAbstractClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public sealed class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
