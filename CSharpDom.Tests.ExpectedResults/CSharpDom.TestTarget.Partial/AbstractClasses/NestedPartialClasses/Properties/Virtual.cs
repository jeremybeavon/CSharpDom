namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedPartialClasses.Properties
{
    public abstract class AbstractClassWithNestedPartialClassWithVirtualProperty
    {
        public partial class Class
        {
            public virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
