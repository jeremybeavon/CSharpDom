namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.NestedDelegates
{
    public class ClassWithNestedAbstractPartialClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        public abstract partial class Class
        {
            [Attribute1, Attribute2]
            public delegate void DelegateWith2AttributesIn1AttributeGroup();
        }
    }
}
