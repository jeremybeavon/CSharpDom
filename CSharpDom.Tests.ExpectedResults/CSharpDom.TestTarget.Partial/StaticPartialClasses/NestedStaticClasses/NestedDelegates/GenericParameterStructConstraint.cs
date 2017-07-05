namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
