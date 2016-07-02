namespace CSharpDom.TestTarget.Classes.NestedClasses.Methods
{
    public class ClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups
    {
        public class Class
        {
            [return: Attribute1]
            [return: Attribute2]
            public void Method()
            {
            }
        }
    }
}
