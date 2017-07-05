namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public static class Class
        {
            public static class NestedClass<T>
                where T : IInterface
            {
            }
        }
    }
}
