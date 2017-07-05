namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedAbstractClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
