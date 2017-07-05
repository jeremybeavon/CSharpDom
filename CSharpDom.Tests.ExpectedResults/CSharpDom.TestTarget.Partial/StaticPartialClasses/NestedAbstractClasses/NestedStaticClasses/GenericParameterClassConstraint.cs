namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
