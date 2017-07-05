namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedClasses.NestedDelegates
{
    public sealed partial class SealedPartialClassWithNestedClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        public class Class
        {
            [Attribute1, Attribute2]
            public delegate void DelegateWith2AttributesIn1AttributeGroup();
        }
    }
}
