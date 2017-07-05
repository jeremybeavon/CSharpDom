namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterClassConstraint<T>()
                where T : class;
        }
    }
}
