namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class<T>
            where T : new()
        {
        }
    }
}
