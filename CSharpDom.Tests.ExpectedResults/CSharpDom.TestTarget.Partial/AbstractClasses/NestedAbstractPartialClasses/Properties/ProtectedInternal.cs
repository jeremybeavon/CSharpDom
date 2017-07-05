namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithProtectedInternalProperty
    {
        public abstract partial class Class
        {
            protected internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
