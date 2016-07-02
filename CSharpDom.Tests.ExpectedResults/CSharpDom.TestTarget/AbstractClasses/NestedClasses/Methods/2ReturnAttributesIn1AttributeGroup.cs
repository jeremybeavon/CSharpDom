namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.Methods
{
    public abstract class AbstractClassWithNestedClassWithMethodWith2ReturnAttributesIn1AttributeGroup
    {
        public class Class
        {
            [return: Attribute1, Attribute2]
            public void Method()
            {
            }
        }
    }
}
