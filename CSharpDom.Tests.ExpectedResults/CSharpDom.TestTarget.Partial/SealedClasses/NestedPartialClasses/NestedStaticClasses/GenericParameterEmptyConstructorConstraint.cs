namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
