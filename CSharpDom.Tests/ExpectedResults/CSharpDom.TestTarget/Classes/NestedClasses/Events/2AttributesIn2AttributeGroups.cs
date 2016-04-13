namespace CSharpDom.TestTarget.Classes.NestedClasses.Events
{
    public class ClassWithNestedClassWithEventWith2AttributesIn2AttributeGroups
    {
        public class Class
        {
            [Attribute1]
            [Attribute2]
            public event EventHandler Event;
        }
    }
}
