namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStaticPartialClasses.Methods
{
    public sealed class SealedClassWithNestedStaticPartialClassWithMethodWith2ReturnAttributesIn1AttributeGroup
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
