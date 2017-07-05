namespace CSharpDom.TestTarget.Partial.StaticPartialClasses.NestedAbstractClasses.NestedDelegates
{
    public static partial class StaticPartialClassWithNestedAbstractClassWithNestedDelegateWithParametersWithAttributes
    {
        public abstract class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
