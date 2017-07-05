namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedDelegates
{
    public partial class PartialClassWithNestedStaticClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
