namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedClasses
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedClassWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
