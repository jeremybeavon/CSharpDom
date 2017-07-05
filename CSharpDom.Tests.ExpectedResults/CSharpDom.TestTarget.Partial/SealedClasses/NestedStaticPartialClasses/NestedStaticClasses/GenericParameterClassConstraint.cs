namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
