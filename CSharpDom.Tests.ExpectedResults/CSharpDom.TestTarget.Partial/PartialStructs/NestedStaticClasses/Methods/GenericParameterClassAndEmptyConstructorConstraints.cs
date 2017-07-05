namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.Methods
{
    public partial struct PartialStructWithWithNestedStaticClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public static class Class
        {
            public static T Method<T>()
                where T : class, new()
            {
                return default(T);
            }
        }
    }
}
