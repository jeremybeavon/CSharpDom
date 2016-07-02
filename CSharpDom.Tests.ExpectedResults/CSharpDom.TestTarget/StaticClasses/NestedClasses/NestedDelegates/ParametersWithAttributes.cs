namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedDelegates
{
    public static class StaticClassWithNestedClassWithNestedClassWithNestedDelegateWithParametersWithAttributes
    {
        public class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
