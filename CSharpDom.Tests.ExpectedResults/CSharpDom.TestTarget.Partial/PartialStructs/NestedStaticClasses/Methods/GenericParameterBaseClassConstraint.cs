namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.Methods
{
    public partial struct PartialStructWithWithNestedStaticClassWithMethodWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public static T Method<T>()
                where T : BaseClass
            {
                return default(T);
            }
        }
    }
}
