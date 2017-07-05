namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
