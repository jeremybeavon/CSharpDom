namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedPartialClassWithNestedSealedPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public sealed class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
