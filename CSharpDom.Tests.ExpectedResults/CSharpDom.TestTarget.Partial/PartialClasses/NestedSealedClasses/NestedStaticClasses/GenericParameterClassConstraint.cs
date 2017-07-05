namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.NestedStaticClasses
{
    public partial class PartialClassWithNestedSealedClassWithNestedStaticClassWithGenericParameterClassConstraint
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
