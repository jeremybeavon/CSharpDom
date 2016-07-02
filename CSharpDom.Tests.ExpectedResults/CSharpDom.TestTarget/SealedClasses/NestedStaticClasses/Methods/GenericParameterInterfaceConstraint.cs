namespace CSharpDom.TestTarget.SealedClasses.NestedStaticClasses.Methods
{
    public sealed class SealedClassWithNestedStaticClassWithMethodWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public static T Method<T>()
                where T : IInterface
            {
                return default(T);
            }
        }
    }
}
