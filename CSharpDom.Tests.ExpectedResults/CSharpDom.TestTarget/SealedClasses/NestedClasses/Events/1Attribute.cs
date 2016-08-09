namespace CSharpDom.TestTarget.SealedClasses.NestedClasses.Events
{
    public sealed class SealedClassWithNestedClassWithEventWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
