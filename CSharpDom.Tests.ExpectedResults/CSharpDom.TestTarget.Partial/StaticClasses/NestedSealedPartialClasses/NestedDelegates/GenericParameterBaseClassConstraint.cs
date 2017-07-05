namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedDelegates
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public sealed partial class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
