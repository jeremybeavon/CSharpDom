namespace CSharpDom.TestTarget.Partial.Classes.NestedStaticPartialClasses.Methods
{
    public class ClassWithNestedStaticPartialClassWithMethodWith2ReturnAttributesIn1AttributeGroup
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
