namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class<T>
            where T : new()
        {
        }
    }
}
