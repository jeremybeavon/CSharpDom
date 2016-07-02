namespace CSharpDom.TestTarget.Classes.NestedStaticClasses.Constructors
{
    public class ClassWithNestedStaticClassWithEventWith2AttributesIn2AttributeGroups
    {
        public static class Class
        {
            [Attribute1]
            [Attribute2]
            public static event EventHandler Event;
        }
    }
}
