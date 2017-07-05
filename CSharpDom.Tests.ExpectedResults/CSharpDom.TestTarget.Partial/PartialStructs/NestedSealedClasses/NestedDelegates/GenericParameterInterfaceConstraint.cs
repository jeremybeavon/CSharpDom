namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.NestedDelegates
{
    public partial struct PartialStructWithWithNestedSealedClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
