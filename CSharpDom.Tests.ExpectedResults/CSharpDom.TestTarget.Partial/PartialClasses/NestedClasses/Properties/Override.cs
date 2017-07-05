namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Properties
{
    public partial class PartialClassWithNestedClassWithOverrideProperty
    {
        public class Class : BaseClassWithProperty
        {
            public override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
