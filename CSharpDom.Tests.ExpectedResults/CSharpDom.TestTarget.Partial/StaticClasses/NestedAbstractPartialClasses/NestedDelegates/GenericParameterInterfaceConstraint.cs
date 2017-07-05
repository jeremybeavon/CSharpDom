namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractPartialClasses.NestedDelegates
{
    public static class StaticClassWithNestedAbstractPartialClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public abstract partial class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
