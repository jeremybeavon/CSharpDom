namespace CSharpDom.TestTarget.Partial.Structs.NestedStaticClasses
{
    public struct StructWithNestedStaticPartialClassWithGenericParameterInterfaceConstraint
    {
        public static class Class<T>
            where T : IInterface
        {
        }
    }
}
