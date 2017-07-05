namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
