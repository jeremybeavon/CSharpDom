namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.NestedDelegates
{
    public abstract class AbstractClassWithNestedStructWithNestedDelegateWith2AttributesIn2AttributeGroups
    {
        public struct Struct
        {
            [Attribute1]
            [Attribute2]
            public delegate void DelegateWith2AttributesIn2AttributeGroups();
        }
    }
}
