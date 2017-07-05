namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.NestedSealedClasses
{
    public sealed class SealedClassWithNestedStaticPartialClassWithNestedSealedPartialClassWithGenericParameterClassConstraint
    {
        public static partial class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
