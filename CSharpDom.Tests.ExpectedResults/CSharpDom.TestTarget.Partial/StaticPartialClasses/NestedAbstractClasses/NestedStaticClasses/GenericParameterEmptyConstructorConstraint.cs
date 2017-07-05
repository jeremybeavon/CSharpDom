namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedStaticClasses
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
