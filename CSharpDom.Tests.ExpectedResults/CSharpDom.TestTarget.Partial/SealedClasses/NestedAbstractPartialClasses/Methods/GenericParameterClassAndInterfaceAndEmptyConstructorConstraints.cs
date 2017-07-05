namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.Methods
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract partial class Class
        {
            public T Method<T>()
                where T : class, IInterface, new()
            {
                return default(T);
            }
        }
    }
}
