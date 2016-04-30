namespace CSharpDom.TestTarget.StaticClasses.NestedDelegates
{
    public static class StaticClassWithNestedDelegateWithParametersWithAttributes
    {
        public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
    }
}
