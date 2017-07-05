namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
