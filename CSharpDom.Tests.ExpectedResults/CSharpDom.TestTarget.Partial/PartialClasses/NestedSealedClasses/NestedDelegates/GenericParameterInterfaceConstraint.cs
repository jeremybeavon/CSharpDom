namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedDelegates
{
    public partial class PartialClassWithNestedSealedClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
