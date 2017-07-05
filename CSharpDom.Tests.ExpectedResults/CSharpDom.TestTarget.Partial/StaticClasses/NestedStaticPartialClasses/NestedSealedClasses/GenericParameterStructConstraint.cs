namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedSealedPartialClassWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
