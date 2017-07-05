namespace CSharpDom.TestTarget.Partial.Classes.NestedSealedPartialClasses.Methods
{
    public class ClassWithNestedSealedPartialClassWithMethodWithParametersWithAttributes
    {
        public sealed partial class Class
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
