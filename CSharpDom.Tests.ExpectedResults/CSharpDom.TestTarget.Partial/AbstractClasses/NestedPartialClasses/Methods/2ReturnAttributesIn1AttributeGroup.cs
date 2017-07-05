namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedPartialClassWithMethodWith2ReturnAttributesIn1AttributeGroup
    {
        public partial class Class
        {
            [return: Attribute1, Attribute2]
            public void Method()
            {
            }
        }
    }
}
