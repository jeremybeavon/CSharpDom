namespace CSharpDom.TestTarget.Classes.NestedClasses.Events
{
    public sealed class ClassWithNestedClassWithEventWith2AttributesIn1AttributeGroup
    {
        public class Class
        {
            [Attribute1, Attribute2]
            public event EventHandler Event;
        }
    }
}
