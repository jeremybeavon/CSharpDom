namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.Methods
{
    public static class StaticClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public class Class
        {
            public T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}
