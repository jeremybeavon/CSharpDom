namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.Events
{
    public class ClassWithNestedAbstractClassWithEventWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
