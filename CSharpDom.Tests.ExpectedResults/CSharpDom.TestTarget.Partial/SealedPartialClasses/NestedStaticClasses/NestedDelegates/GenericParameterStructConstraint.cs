namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
