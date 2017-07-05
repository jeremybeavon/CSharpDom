namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedStaticClasses
{
    public sealed class SealedClassWithNestedPartialClassWithNestedStaticPartialClassWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
