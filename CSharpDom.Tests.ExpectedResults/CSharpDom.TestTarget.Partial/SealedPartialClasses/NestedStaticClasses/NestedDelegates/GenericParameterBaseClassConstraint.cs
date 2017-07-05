namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
