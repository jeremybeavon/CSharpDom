namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Methods
{
    public class ClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public T Method<T>()
                where T : class, IInterface, new()
            {
                return default(T);
            }
        }
    }
}
