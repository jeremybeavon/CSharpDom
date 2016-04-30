namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Properties
{
    public abstract class AbstractClassWithNestedAbstractClassWithPrivateProperty
    {
        public abstract class Class
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
