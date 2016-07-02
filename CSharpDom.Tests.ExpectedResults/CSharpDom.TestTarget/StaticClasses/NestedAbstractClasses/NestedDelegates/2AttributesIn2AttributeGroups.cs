namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedDelegates
{
    public static class StaticClassWithNestedAbstractClassWithNestedDelegateWith2AttributesIn2AttributeGroups
    {
        public abstract class Class
        {
            [Attribute1]
            [Attribute2]
            public delegate void DelegateWith2AttributesIn2AttributeGroups();
        }
    }
}
