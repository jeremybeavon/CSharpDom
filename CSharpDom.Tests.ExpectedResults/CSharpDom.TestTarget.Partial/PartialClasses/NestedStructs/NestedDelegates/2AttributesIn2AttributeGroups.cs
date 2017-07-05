namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedStructs.NestedDelegates
{
    public partial class PartialClassWithNestedStructWithNestedDelegateWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public delegate void DelegateWith2AttributesIn2AttributeGroups();
        }
    }
}
