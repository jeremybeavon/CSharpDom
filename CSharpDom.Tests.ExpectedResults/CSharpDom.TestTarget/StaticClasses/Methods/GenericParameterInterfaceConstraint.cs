namespace CSharpDom.TestTarget.StaticClasses.Methods
{
    public static class StaticClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public static T Method<T>()
            where T : IInterface
        {
            return default(T);
        }
    }
}
