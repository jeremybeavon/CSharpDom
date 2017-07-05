namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterStructConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : struct
            {
            }
        }
    }
}
