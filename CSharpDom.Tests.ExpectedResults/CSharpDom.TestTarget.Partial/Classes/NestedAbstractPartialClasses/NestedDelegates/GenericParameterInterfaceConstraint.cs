namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedDelegates
{
    public class ClassWithNestedAbstractPartialClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
