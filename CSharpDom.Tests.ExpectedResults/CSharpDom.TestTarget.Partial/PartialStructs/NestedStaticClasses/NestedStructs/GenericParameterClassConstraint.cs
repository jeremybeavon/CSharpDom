namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedStructs
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedStructWithGenericParameterClassConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
