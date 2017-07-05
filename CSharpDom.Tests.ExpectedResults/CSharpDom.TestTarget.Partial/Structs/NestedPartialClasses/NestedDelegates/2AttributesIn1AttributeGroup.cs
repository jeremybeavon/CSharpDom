namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.NestedDelegates
{
    public struct StructWithNestedPartialClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        public partial class Class
        {
            [Attribute1, Attribute2]
            public delegate void DelegateWith2AttributesIn1AttributeGroup();
        }
    }
}
