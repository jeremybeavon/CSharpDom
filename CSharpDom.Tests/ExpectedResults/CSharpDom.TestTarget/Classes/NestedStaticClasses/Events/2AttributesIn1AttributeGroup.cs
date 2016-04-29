namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.Events
{
    public class ClassWithNestedStaticClassWithEventWith2AttributesIn1AttributeGroup
    {
        public static class Class
        {
            [Attribute1, Attribute2]
            public static event EventHandler Event;
        }
    }
}
