namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedClasses
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
