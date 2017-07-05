namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedDelegateWithGenericParameterInterfaceConstraint
    {
        public sealed partial class Class
        {
            public delegate void DelegateWithGenericParameterInterfaceConstraint<T>()
                where T : IInterface;
        }
    }
}
