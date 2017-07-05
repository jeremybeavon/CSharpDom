namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class<T>
            where T : new()
        {
        }
    }
}
