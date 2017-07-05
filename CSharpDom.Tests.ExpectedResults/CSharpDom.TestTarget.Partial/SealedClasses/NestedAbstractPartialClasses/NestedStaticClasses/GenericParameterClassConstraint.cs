namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedAbstractPartialClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedAbstractPartialClassWithNestedStaticPartialClassWithGenericParameterClassConstraint
    {
        public abstract partial class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
