namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
            where T : IInterface;
    }
}
