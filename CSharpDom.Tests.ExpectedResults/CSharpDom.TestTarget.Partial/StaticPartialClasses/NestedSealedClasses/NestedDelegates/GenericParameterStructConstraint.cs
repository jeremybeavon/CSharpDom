namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedDelegateWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public delegate void DelegateWithGenericParameterStructConstraint<T>()
                where T : struct;
        }
    }
}
