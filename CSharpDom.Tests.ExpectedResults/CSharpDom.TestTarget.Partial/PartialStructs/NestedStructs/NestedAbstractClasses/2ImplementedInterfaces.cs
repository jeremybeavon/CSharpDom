namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedStructs.NestedAbstractClasses
{
    public partial struct PartialStructWithNestedStructWithNestedAbstractClassWith2ImplementedInterfaces
    {
        public struct Struct
        {
            public abstract class NestedClass : IInterface1, IInterface2
            {
            }
        }
    }
}
