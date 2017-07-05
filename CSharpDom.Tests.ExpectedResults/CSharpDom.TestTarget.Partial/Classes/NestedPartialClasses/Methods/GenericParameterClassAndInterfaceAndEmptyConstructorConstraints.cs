namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.Methods
{
    public class ClassWithNestedPartialClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
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
