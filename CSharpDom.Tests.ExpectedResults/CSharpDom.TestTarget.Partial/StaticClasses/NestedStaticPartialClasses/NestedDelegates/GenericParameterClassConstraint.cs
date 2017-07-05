namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedDelegates
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
