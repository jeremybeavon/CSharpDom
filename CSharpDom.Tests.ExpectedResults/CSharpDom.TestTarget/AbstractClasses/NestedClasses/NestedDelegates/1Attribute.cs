namespace CSharpDom.TestTarget.AbstractClasses.NestedClasses.NestedDelegates
{
    public abstract class AbstractClassWithNestedClassWithNestedDelegateWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
