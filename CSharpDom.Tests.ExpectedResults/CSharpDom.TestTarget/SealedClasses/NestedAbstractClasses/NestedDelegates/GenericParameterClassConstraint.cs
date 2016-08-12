namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
