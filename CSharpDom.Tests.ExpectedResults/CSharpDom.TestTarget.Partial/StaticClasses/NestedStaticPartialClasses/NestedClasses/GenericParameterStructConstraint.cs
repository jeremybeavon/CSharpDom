namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedStaticPartialClasses.NestedClasses
{
    public static class StaticClassWithNestedStaticPartialClassWithNestedPartialClassWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
