namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedSealedClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedSealedClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public delegate void DelegateWith2AttributesIn1AttributeGroup();
        }
    }
}
