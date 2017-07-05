namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public abstract partial class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
