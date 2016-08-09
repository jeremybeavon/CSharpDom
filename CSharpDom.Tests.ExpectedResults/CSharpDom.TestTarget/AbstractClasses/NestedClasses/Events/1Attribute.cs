namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Events
{
    public abstract class AbstractClassWithNestedClassWithEventWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
