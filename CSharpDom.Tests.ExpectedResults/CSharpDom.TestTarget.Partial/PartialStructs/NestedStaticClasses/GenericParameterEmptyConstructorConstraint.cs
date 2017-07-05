namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses
{
    public partial struct PartialStructWithWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class<T>
            where T : new()
        {
        }
    }
}
