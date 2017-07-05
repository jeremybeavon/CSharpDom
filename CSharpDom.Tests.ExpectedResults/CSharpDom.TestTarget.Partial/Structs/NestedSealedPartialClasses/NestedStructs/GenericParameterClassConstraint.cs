namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedStructs
{
    public struct StructWithNestedSealedPartialClassWithNestedStructWithGenericParameterClassConstraint
    {
        public sealed partial class Class
        {
            public struct NestedStruct<T>
                where T : class
            {
            }
        }
    }
}
