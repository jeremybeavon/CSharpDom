namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : class, IInterface, new()
            {
            }
        }
    }
}
