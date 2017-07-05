namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedSealedPartialClassWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
