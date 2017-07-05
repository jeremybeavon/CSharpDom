namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedPartialClasses.NestedClasses
{
    public static class StaticClassWithNestedPartialClassWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public partial class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
