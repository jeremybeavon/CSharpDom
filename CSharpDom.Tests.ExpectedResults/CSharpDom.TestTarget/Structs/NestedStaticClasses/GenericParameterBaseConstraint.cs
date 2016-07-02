namespace CSharpDom.TestTarget.Structs.NestedStaticClasses
{
    public struct StructWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public static class Class<T>
            where T : BaseClass
        {
        }
    }
}
