namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events
{
    public sealed class ClassWithNestedAbstractClassWithEventWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
