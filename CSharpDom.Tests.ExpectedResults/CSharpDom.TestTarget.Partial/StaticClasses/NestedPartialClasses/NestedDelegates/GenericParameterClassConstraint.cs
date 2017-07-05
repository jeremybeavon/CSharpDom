namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedDelegates
{
    public static class StaticClassWithNestedPartialClassWithNestedPartialClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
