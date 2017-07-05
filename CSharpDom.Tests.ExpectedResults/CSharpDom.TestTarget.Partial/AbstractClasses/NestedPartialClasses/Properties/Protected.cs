namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedPartialClassWithProtectedProperty
    {
        public partial class Class
        {
            protected string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
