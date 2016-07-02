namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class<T>
            where T : class, new()
        {
        }
    }
}
