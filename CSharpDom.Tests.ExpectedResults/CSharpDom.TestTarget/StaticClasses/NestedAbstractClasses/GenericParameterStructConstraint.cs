namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedAbstractClassWithGenericParameterStructConstraint
    {
        public abstract class Class<T>
            where T : struct
        {
        }
    }
}
