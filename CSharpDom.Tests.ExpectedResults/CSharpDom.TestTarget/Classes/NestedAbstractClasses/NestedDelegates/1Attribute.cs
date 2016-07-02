namespace CSharpDom.TestTarget.Classes.NestedAbstractClasses.NestedDelegates
{
    public class ClassWithNestedAbstractClassWithNestedDelegateWith1Attribute
    {
        public abstract class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
