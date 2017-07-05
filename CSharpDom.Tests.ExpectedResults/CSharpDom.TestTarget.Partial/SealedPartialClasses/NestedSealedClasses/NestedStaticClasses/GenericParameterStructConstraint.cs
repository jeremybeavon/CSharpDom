namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedSealedClasses.NestedStaticClasses
{
    public sealed partial class SealedPartialClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public sealed class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
