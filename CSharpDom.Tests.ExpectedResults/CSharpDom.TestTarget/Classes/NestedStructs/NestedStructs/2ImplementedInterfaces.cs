namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedStructs
{
    public class ClassWithNestedStructWithNestedStructWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public struct NestedStruct : IInterface1, IInterface2
            {
            }
        }
    }
}
