namespace CSharpDom.TestTarget.AbstractClasses.NestedSealedClasses
{
    public abstract class AbstractClassWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
