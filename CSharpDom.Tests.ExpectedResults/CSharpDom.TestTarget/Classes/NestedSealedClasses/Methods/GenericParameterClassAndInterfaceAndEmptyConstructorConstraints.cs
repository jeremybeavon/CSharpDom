namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Methods
{
    public class ClassWithNestedSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public sealed class Class
        {
            public T Method<T>()
                where T : class, IInterface, new()
            {
                return default(T);
            }
        }
    }
}
