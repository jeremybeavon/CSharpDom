namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.NestedDelegates
{
    public class ClassWithNestedSealedPartialClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        public sealed partial class Class
        {
            [Attribute1, Attribute2]
            public delegate void DelegateWith2AttributesIn1AttributeGroup();
        }
    }
}
