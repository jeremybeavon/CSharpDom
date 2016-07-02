namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Events
{
    public sealed class ClassWithNestedSealedClassWithEventWith1Attribute
    {
        public sealed class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
