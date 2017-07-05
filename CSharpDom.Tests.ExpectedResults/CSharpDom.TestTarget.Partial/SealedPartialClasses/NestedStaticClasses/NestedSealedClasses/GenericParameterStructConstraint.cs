namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStaticClasses.NestedSealedClasses
{
    public sealed partial class SealedPartialClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
