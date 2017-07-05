namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
