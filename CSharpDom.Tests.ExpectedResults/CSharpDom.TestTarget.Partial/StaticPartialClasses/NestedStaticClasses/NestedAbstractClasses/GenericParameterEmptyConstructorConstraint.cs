namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedStaticClasses.NestedAbstractClasses
{
    public static partial class StaticPartialClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
