namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedStaticClassWithGenericParameterBaseClassConstraint
    {
        public static class Class<T>
            where T : BaseClass
        {
        }
    }
}
