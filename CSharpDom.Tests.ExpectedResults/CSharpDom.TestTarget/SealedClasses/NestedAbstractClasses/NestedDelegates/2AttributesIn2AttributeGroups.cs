namespace CSharpDom.TestTarget.SealedClasses.NestedAbstractClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedAbstractClassWithNestedDelegateWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [Attribute1]
            [Attribute2]
            public delegate void DelegateWith2AttributesIn2AttributeGroups();
        }
    }
}
