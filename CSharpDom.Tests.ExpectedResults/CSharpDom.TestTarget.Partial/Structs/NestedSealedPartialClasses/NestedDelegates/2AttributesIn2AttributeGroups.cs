namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.NestedDelegates
{
    public struct StructWithNestedSealedPartialClassWithNestedDelegateWith2AttributesIn2AttributeGroups
    {
        public sealed partial class Class
        {
            [Attribute1]
            [Attribute2]
            public delegate void DelegateWith2AttributesIn2AttributeGroups();
        }
    }
}
