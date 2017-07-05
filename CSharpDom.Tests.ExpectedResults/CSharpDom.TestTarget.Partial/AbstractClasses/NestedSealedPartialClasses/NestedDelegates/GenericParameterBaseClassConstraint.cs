namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedSealedPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedSealedPartialClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public sealed partial class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
