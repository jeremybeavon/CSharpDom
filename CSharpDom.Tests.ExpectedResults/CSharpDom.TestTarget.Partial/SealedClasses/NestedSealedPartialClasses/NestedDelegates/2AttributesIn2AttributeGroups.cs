namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedSealedPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedSealedPartialClassWithNestedDelegateWith2AttributesIn2AttributeGroups
    {
        public sealed partial class Class
        {
            [Attribute1]
            [Attribute2]
            public delegate void DelegateWith2AttributesIn2AttributeGroups();
        }
    }
}
