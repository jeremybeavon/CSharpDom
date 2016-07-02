namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Events
{
    public sealed class ClassWithNestedSealedClassWithEventWith2AttributesIn1AttributeGroup
    {
        public sealed class Class
        {
            [Attribute1, Attribute2]
            public event EventHandler Event;
        }
    }
}
