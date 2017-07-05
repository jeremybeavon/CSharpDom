namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStaticClasses.NestedStructs
{
    public partial struct PartialStructWithWithNestedStaticClassWithNestedStructWithGenericParameterStructConstraint
    {
        public static class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
