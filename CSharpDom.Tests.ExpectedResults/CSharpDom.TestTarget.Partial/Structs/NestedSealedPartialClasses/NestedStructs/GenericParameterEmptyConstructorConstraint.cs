namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedStructs
{
    public struct StructWithNestedSealedPartialClassWithNestedStructWithGenericParameterEmptyConstructorConstraint
    {
        public sealed partial class Class
        {
            public struct NestedStruct<T>
                where T : new()
            {
            }
        }
    }
}
