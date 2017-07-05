namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedPartialClasses.NestedDelegates
{
    public sealed class SealedClassWithNestedPartialClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        public partial class Class
        {
            [Attribute1, Attribute2]
            public delegate void DelegateWith2AttributesIn1AttributeGroup();
        }
    }
}
