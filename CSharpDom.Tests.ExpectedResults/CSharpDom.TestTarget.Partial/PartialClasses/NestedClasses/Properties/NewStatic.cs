namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Properties
{
    public partial class PartialClassWithNestedClassWithNewStaticProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
