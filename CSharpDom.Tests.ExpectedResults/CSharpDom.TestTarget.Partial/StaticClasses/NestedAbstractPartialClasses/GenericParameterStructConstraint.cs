namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedAbstractPartialClassWithGenericParameterStructConstraint
    {
        public abstract class Class<T>
            where T : struct
        {
        }
    }
}
