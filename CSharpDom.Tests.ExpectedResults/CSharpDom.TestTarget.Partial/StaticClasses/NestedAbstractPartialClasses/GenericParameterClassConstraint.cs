namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedAbstractPartialClassWithGenericParameterClassConstraint
    {
        public abstract class Class<T>
            where T : class
        {
        }
    }
}
