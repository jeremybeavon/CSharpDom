namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.NestedDelegates
{
    public partial class PartialClassWithNestedClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
