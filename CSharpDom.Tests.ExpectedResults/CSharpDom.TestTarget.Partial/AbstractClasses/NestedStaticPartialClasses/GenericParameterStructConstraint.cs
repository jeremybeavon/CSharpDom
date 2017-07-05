namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithGenericParameterStructConstraint
    {
        public static class Class<T>
            where T : struct
        {
        }
    }
}
