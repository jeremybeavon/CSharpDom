namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedDelegates
{
    public class ClassWithNestedStructWithNestedDelegateWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public delegate void DelegateWith2AttributesIn2AttributeGroups();
        }
    }
}
