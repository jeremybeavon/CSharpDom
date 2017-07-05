namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Properties
{
    public partial class PartialClassWithNestedClassWithNewVirtualProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
