namespace CSharpDom.TestTarget.Classes.NestedDelegates
{
    public class ClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
            where T : IInterface;
    }
}
