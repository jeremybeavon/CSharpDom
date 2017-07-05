namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class<T>
            where T : class, IInterface, new()
        {
        }
    }
}
