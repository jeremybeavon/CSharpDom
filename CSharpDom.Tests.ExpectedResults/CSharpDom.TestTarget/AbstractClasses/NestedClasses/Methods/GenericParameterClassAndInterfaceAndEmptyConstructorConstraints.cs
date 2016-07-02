namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Methods
{
    public abstract class AbstractClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
