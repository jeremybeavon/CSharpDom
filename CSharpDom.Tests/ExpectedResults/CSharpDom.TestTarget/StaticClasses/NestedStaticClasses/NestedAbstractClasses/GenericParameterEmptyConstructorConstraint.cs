namespace CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public abstract class NestedClass<T>
                where T : new()
            {
            }
        }
    }
}
