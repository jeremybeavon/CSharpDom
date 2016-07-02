namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedDelegates
{
    public struct StructWithNestedSealedClassWithNestedDelegateWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public delegate void DelegateWith2AttributesIn2AttributeGroups();
        }
    }
}
