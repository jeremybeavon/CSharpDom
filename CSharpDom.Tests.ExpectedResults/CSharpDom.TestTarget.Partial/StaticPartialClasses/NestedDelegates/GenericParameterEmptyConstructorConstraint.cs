namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
            where T : new();
    }
}
