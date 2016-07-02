namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedStaticClasses
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
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
