namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
