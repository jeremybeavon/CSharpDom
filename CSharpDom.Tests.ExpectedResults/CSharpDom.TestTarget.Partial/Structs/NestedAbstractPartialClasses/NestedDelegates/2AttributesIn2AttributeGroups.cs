namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.NestedDelegates
{
    public struct StructWithNestedAbstractPartialClassWithNestedDelegateWith2AttributesIn2AttributeGroups
    {
        public abstract partial class Class
        {
            [Attribute1]
            [Attribute2]
            public delegate void DelegateWith2AttributesIn2AttributeGroups();
        }
    }
}
