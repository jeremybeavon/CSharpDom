namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedAbstractClasses
{
    public static class StaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public abstract class Class
        {
            public abstract class NestedClass<T>
                where T : class, new()
            {
            }
        }
    }
}
