namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedAbstractClassWithNestedDelegateWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
