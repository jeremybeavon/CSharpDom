namespace CSharpDom.TestTarget.Partial.StaticClasses.NestedSealedPartialClasses.NestedDelegates
{
    public static class StaticClassWithNestedSealedPartialClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [Attribute1, Attribute2]
            public delegate void DelegateWith2AttributesIn1AttributeGroup();
        }
    }
}
