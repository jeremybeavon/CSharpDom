namespace CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedStaticClassWithNestedDelegateWith1Attribute
    {
        public static class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
