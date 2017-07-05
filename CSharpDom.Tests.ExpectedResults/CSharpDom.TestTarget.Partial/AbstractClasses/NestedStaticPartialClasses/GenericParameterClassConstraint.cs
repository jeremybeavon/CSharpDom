namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithGenericParameterClassConstraint
    {
        public static class Class<T>
            where T : class
        {
        }
    }
}
