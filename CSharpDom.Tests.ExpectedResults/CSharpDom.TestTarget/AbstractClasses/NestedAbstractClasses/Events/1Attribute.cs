namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Events
{
    public abstract class AbstractClassWithNestedAbstractClassWithEventWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
