namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Methods
{
    public sealed class SealedClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public class Class
        {
            public T Method<T>()
                where T : class, IInterface, new()
            {
                return default(T);
            }
        }
    }
}
