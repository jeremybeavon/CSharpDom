namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Properties
{
    public abstract class AbstractClassWithNestedAbstractClassWithProtectedProperty
    {
        public abstract class Class
        {
            protected string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
