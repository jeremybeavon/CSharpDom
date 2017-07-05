namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
