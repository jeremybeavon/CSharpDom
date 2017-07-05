namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
