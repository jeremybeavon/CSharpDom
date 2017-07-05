namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStaticClasses.NestedDelegates
{
    public partial class PartialClassWithNestedStaticClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
