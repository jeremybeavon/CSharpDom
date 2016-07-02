namespace CSharpDom.TestTarget.StaticClasses.Methods
{
    public static class StaticClassWithMethodWithGenericParameterBaseSealedClassConstraint
    {
        public static T Method<T>()
            where T : BaseClass
        {
            return default(T);
        }
    }
}
