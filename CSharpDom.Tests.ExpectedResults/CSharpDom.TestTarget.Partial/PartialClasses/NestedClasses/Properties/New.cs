namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Properties
{
    public partial class PartialClassWithNestedClassWithNewProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
