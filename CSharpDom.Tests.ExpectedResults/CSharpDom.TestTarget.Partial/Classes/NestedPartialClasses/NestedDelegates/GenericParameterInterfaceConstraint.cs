namespace CSharpDom.TestTarget.Partial.Classes.NestedPartialClasses.NestedDelegates
{
    public class ClassWithNestedPartialClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public partial class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
