namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
