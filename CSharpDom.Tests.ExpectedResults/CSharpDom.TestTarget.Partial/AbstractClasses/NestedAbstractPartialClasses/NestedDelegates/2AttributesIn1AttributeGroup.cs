namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        public abstract partial class Class
        {
            [Attribute1, Attribute2]
            public delegate void DelegateWith2AttributesIn1AttributeGroup();
        }
    }
}
