namespace CSharpDom.TestTarget.StaticClasses.NestedSealedClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedSealedClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public abstract class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
