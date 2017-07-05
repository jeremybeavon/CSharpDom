namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.Methods
{
    public partial class PartialClassWithNestedAbstractClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
