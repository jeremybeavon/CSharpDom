namespace CSharpDom.TestTarget.AbstractClasses.Methods
{
    public abstract class AbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public T Method<T>()
            where T : class, IInterface, new()
        {
            return default(T);
        }
    }
}
