namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedSealedClasses
{
    public static class StaticClassWithNestedPartialClassWithNestedSealedPartialClassWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public sealed class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
