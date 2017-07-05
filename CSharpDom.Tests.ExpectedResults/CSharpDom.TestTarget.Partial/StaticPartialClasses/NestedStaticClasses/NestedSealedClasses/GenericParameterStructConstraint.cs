namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedSealedClasses
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedSealedClassWithGenericParameterStructConstraint
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
