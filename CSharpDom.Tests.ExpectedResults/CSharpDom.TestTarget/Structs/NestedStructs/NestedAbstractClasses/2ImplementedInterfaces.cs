namespace CSharpDom.TestTarget.Structs.NestedStructs.NestedAbstractClasses
{
    public struct StructWithNestedStructWithNestedAbstractClassWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public abstract class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
