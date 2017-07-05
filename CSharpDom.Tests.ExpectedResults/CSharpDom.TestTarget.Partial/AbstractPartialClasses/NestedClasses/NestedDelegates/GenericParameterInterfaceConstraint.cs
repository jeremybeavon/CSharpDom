namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
