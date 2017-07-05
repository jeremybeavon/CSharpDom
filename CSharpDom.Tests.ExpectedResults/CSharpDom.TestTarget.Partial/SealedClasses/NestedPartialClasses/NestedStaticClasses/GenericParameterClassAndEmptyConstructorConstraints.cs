namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
