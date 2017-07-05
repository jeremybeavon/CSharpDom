namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedAbstractPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedAbstractPartialClassWithProtectedProperty
    {
        public abstract partial class Class
        {
            protected string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
