namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedDelegates
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
