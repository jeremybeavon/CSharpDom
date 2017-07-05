namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.Methods
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithMethodWith2ReturnAttributesIn1AttributeGroup
    {
        public static partial class Class
        {
            [return: Attribute1, Attribute2]
            public static void Method()
            {
            }
        }
    }
}
