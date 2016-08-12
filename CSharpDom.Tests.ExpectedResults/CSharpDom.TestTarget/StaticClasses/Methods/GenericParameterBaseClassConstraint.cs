namespace CSharpDom.TestTarget.StaticClasses.Methods
{
    public static class StaticClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public static T Method<T>()
            where T : BaseClass
        {
            return default(T);
        }
    }
}
