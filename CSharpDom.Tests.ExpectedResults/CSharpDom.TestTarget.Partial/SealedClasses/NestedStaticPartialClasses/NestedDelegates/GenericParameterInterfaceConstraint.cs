namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
