namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
