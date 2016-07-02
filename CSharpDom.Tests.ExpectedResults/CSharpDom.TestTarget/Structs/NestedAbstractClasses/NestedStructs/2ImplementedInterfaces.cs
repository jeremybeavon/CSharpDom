namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.NestedStructs
{
    public struct StructWithNestedAbstractClassWithNestedStructWith2ImplementedInterfaces
    {
        public abstract class Class
        {
            public struct NestedStruct : IInterface1, IInterface2
            {
            }
        }
    }
}
