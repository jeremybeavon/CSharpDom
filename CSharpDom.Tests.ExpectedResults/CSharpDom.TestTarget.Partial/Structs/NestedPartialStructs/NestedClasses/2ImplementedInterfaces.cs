namespace CSharpDom.TestTarget.Partial.Structs.NestedStructs.NestedClasses
{
    public struct StructWithNestedStructWithNestedPartialClassWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
