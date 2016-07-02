namespace CSharpDom.TestTarget.Classes.NestedSealedClasses.Methods
{
    public class ClassWithNestedSealedClassWithMethodWithParametersWithAttributes
    {
        public sealed class Class
        {
            public void Method([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
