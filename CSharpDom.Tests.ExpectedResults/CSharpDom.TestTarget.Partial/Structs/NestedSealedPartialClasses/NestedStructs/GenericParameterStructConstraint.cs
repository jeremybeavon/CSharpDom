namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedStructs
{
    public struct StructWithNestedSealedPartialClassWithNestedStructWithGenericParameterStructConstraint
    {
        public sealed partial class Class
        {
            public struct NestedStruct<T>
                where T : struct
            {
            }
        }
    }
}
