namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedStructs
{
    public struct StructWithNestedPartialClassWithNestedStructWith2ImplementedInterfaces
    {
        public partial class Class
        {
            public struct NestedStruct : IInterface1, IInterface2
            {
            }
        }
    }
}
