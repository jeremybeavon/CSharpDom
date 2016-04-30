namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedClassWithNestedDelegateWith2AttributesIn2AttributeGroups
    {
        public class Class
        {
            [Attribute1]
            [Attribute2]
            public delegate void DelegateWith2AttributesIn2AttributeGroups();
        }
    }
}
