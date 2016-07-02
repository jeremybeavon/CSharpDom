namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.Methods
{
    public struct StructWithNestedStaticClassWithMethodWithGenericParameterInterfaceConstraint
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
