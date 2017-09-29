namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedStaticClasses
{
    public partial struct PartialStructWithNestedStaticClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : BaseClass
            {
            }
        }
    }
}
