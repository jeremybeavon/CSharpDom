namespace CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.Properties
{
    public abstract class AbstractClassWithNestedAbstractClassWithInternalProperty
    {
        public abstract class Class
        {
            internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
