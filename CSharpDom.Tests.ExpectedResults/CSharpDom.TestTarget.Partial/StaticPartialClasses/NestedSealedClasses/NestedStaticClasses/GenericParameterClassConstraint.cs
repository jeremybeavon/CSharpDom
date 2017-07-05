namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassConstraint
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
