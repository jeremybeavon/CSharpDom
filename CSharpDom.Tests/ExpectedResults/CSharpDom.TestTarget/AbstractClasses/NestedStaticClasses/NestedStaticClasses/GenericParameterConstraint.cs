namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
