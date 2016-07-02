namespace CSharpDom.TestTarget.StaticClasses.Methods
{
    public static class StaticClassWithMethodWithGenericParameterSealedClassConstraint
    {
        public static T Method<T>()
            where T : class
        {
            return default(T);
        }
    }
}
