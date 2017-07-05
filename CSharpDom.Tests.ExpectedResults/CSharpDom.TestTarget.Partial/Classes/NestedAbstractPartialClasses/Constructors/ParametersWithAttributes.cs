namespace CSharpDom.TestTarget.Partial.Classes.NestedAbstractPartialClasses.Constructors
{
    public class ClassWithNestedAbstractPartialClassWithConstructorWithParametersWithAttributes
    {
        public abstract partial class Class
        {
            public Class([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2)
            {
            }
        }
    }
}
