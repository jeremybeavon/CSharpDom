namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedClasses.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
