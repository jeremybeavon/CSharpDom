namespace CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedStaticClasses
{
    public struct StructWithNestedStaticClassWithNestedStaticClassWithGenericParameterBaseClassConstraint
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
