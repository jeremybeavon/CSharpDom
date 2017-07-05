namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStaticPartialClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedStaticPartialClassWithNestedDelegateWith1Attribute
    {
        public static partial class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
