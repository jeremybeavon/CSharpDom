namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
