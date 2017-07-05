namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedSealedPartialClassWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public sealed class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
