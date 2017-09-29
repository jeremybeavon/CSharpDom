namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.NestedStructs
{
    public partial struct PartialStructWithNestedAbstractClassWithNestedStructWith2ImplementedInterfaces
    {
        public abstract class Class
        {
            public struct NestedStruct : IInterface1, IInterface2
            {
            }
        }
    }
}
