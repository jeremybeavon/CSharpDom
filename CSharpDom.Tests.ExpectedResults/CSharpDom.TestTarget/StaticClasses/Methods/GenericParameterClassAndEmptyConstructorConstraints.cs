namespace CSharpDom.TestTarget.StaticClasses.Methods
{
    public static class StaticClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static T Method<T>()
            where T : class, new()
        {
            return default(T);
        }
    }
}
