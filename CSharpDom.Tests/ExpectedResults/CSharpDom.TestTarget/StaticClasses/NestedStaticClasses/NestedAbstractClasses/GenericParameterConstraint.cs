namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : class
            {
            }
        }
    }
}
