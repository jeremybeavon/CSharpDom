namespace CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedDelegates
{
    public static class StaticClassWithNestedAbstractClassWithNestedDelegateWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
