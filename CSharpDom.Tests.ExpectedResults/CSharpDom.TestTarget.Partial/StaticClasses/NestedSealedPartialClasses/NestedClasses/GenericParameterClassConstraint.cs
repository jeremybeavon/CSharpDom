namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
