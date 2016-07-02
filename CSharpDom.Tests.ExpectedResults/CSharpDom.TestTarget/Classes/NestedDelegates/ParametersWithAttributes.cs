namespace CSharpDom.TestTarget.Classes.NestedDelegates
{
    public class ClassWithNestedDelegateWithParametersWithAttributes
    {
        public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
    }
}
