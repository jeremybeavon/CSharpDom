namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedStaticClasses
{
    public struct StructWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraint
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
