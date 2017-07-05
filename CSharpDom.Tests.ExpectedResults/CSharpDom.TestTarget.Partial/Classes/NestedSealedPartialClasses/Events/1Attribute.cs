namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Events
{
    public class ClassWithNestedSealedPartialClassWithEventWith1Attribute
    {
        public sealed partial class Class
        {
            [Attribute1]
            public event EventHandler Event;
        }
    }
}
