namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedDelegateWithGenericParameterBaseClassConstraint
    {
        public static partial class Class
        {
            public delegate void DelegateWithGenericParameterBaseClassConstraint<T>()
                where T : BaseClass;
        }
    }
}
