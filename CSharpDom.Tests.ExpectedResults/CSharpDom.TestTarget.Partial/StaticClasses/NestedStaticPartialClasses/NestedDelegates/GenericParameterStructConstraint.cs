namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedDelegates
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
