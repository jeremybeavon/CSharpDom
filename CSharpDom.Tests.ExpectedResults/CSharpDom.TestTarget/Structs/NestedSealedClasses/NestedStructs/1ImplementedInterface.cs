namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedStructs
{
    public struct StructWithNestedSealedClassWithNestedStructWith1ImplementedInterface
    {
        public sealed class Class
        {
            public struct NestedStruct : IInterface
            {
            }
        }
    }
}
