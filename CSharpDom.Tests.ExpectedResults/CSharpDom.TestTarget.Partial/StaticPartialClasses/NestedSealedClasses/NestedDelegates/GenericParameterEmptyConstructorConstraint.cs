namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterEmptyConstructorConstraint<T>()
                where T : new();
        }
    }
}
