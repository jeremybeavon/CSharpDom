namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterClassConstraint
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
