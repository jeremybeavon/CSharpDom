namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.Methods
{
    public struct StructWithNestedStaticClassWithMethodWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public static T Method<T>()
                where T : class
            {
                return default(T);
            }
        }
    }
}
