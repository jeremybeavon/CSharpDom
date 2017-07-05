namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.Events
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithEventWith2AttributesIn1AttributeGroup
    {
        public static partial class Class
        {
            [Attribute1, Attribute2]
            public static event EventHandler Event;
        }
    }
}
