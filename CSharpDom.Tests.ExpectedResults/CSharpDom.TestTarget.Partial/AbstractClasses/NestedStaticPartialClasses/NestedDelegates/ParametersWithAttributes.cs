namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedDelegateWithParametersWithAttributes
    {
        public static partial class Class
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
