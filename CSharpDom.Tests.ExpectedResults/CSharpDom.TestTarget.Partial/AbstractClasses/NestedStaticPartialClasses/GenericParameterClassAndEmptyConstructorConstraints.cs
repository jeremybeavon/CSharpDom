namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class<T>
            where T : class, new()
        {
        }
    }
}
