namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public delegate void DelegateWithGenericParameterStructConstraint<T>()
            where T : struct;
    }
}
