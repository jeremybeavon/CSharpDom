namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedStructs
{
    public struct StructWithNestedSealedPartialClassWithNestedStructWith2GenericParameters
    {
        public sealed partial class Class
        {
            public struct NestedStruct<TKey, TValue>
            {
            }
        }
    }
}
