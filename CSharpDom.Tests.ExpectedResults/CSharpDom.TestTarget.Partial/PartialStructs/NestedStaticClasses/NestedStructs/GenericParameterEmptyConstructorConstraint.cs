namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedStructs
{
    public partial struct PartialStructWithNestedStaticClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
