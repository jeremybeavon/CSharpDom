namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Methods
{
    public class ClassWithNestedAbstractPartialClassWithMethodWith2ReturnAttributesIn1AttributeGroup
    {
        public abstract partial class Class
        {
            [return: Attribute1, Attribute2]
            public void Method()
            {
            }
        }
    }
}
