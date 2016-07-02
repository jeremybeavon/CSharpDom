namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithAttributes
    {
        public class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
