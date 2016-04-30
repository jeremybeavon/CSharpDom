namespace CSharpDom.TestTarget.StaticClasses.Methods
{
    public static class StaticClassWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public static T Method<T>()
            where T : new()
        {
            return default(T);
        }
    }
}
