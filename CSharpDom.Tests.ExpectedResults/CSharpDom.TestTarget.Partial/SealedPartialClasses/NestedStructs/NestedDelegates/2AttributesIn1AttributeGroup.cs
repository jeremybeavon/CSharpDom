namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedStructWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        public struct Struct
        {
            [Attribute1, Attribute2]
            public delegate void DelegateWith2AttributesIn1AttributeGroup();
        }
    }
}
