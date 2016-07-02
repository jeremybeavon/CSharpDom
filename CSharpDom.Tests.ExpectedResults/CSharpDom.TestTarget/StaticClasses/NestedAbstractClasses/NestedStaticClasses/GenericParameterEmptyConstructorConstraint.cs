namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedStaticClasses
{
    public static class StaticClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public abstract class Class
        {
            public static class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
