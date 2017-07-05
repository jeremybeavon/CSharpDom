namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedDelegates
{
    public static class StaticClassWithNestedPartialClassWithNestedDelegateWithGenericParameterGenericParameterConstraint
    {
        public partial class Class
        {
            public delegate void DelegateWithGenericParameterGenericParameterConstraint<TKey, TValue>()
                where TKey : TValue;
        }
    }
}
