namespace CSharpDom.TestTarget.StaticClasses.Methods
{
    public static class StaticClassWithMethodWithGenericParameterStructConstraint
    {
        public static T Method<T>()
            where T : struct
        {
            return default(T);
        }
    }
}
