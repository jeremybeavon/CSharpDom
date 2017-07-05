namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedPartialClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public T Method<T>()
                where T : class, IInterface, new()
            {
                return default(T);
            }
        }
    }
}
