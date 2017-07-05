namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Methods
{
    public partial class PartialClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
