namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.NestedDelegates
{
    public abstract partial class AbstractPartialClassWithNestedStructWithNestedDelegateWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public delegate void DelegateWith2AttributesIn2AttributeGroups();
        }
    }
}
