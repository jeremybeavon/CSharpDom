namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedAbstractClasses.NestedDelegates
{
    public partial class PartialClassWithNestedAbstractClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
