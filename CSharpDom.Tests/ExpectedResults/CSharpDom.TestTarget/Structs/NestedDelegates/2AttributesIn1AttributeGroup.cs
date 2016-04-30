namespace CSharpDom.TestTarget.Structs.NestedDelegates
{
    public struct StructWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        [Attribute1, Attribute2]
        public delegate void DelegateWith2AttributesIn1AttributeGroup();
    }
}
