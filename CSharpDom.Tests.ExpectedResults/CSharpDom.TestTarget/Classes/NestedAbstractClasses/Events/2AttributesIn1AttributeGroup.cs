namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events
{
    public sealed class ClassWithNestedAbstractClassWithEventWith2AttributesIn1AttributeGroup
    {
        public abstract class Class
        {
            [Attribute1, Attribute2]
            public event EventHandler Event;
        }
    }
}
