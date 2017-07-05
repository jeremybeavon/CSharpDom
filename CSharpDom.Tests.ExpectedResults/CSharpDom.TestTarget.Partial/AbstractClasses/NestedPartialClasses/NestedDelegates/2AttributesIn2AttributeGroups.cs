namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedPartialClassWithNestedDelegateWith2AttributesIn2AttributeGroups
    {
        public partial class Class
        {
            [Attribute1]
            [Attribute2]
            public delegate void DelegateWith2AttributesIn2AttributeGroups();
        }
    }
}
