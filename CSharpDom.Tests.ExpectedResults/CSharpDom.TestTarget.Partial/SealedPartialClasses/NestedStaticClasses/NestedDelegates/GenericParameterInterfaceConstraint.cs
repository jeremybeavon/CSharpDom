namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
