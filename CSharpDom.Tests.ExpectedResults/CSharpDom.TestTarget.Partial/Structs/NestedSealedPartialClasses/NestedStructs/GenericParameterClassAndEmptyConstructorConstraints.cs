namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedStructs
{
    public struct StructWithNestedSealedPartialClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints
    {
        public sealed partial class Class
        {
            public struct NestedStruct<T>
                where T : class, new()
            {
            }
        }
    }
}
