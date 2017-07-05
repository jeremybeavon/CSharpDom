namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedStaticPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public static partial class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
