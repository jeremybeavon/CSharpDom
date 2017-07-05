namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedDelegates
{
    public partial class PartialClassWithNestedStaticClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
