namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedDelegates
{
    public class ClassWithNestedPartialClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public delegate void DelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints<T>()
                where T : class, IInterface, new();
        }
    }
}
