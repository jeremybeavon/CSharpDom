namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
