namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedDelegates
{
    public static class StaticClassWithNestedPartialClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
