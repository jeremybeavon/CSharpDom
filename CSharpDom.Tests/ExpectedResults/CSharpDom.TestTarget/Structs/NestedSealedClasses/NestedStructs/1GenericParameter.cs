namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedStructs
{
    public struct StructWithNestedSealedClassWithNestedStructWith1GenericParameter
    {
        public sealed class Class
        {
            public struct NestedStruct<T>
            {
            }
        }
    }
}
