namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedDelegates
{
    public class ClassWithNestedAbstractClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public delegate void DelegateWith2AttributesIn1AttributeGroup();
        }
    }
}
