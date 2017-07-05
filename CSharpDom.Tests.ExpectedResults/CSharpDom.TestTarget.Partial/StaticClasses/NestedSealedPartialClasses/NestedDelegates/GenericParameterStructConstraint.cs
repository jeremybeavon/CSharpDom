namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedDelegates
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
