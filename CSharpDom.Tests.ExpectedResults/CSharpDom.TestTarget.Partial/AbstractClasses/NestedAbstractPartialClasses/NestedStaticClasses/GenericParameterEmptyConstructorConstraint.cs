namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedStaticPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract partial class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
