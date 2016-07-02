namespace CSharpDom.TestTarget.Classes.Methods
{
    public class ClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public T Method<T>()
            where T : class, IInterface, new()
        {
            return default(T);
        }
    }
}
