namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedPartialClassWithPrivateProperty
    {
        public partial class Class
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
