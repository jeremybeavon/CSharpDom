namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public static class Class<T>
            where T : class
        {
        }
    }
}
