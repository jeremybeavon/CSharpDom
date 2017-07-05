namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedStaticClassWithGenericParameterInterfaceConstraint
    {
        public static class Class<T>
            where T : IInterface
        {
        }
    }
}
