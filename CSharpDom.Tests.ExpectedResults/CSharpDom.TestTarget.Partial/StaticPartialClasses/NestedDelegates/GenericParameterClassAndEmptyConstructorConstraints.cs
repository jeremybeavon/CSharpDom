namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public delegate void DelegateWithGenericParameterClassAndEmptyConstructorConstraints<T>()
            where T : class, new();
    }
}
