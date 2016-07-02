namespace CSharpDom.TestTarget.StaticClasses.Methods
{
    public static class StaticClassWithMethodWithGenericParameterSealedClassAndEmptyConstructorConstraints
    {
        public static T Method<T>()
            where T : class, new()
        {
            return default(T);
        }
    }
}
