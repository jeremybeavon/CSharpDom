namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.NestedDelegates
{
    public sealed class SealedClassWithNestedStructWithNestedDelegateWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public delegate void DelegateWith2AttributesIn2AttributeGroups();
        }
    }
}
