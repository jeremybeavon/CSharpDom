namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterStructConstraint
    {
        public static partial class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
