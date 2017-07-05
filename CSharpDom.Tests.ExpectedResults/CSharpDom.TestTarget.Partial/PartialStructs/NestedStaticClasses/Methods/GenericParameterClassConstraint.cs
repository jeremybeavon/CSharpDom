namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.Methods
{
    public partial struct PartialStructWithWithNestedStaticClassWithMethodWithGenericParameterClassConstraint
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
