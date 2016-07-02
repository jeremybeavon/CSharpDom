namespace CSharpDom.TestTarget.SealedClasses.NestedSealedClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedSealedClassWithNestedDelegateWith2AttributesIn2AttributeGroups
    {
        public sealed class Class
        {
            [Attribute1]
            [Attribute2]
            public delegate void DelegateWith2AttributesIn2AttributeGroups();
        }
    }
}
