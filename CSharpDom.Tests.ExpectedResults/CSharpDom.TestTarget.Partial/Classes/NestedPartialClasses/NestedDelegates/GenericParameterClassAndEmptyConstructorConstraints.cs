namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedDelegates
{
    public class ClassWithNestedPartialClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
                where T : class, new();
        }
    }
}
