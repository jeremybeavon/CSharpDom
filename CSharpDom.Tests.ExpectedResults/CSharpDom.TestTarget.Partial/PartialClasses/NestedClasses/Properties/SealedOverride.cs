namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedClasses.Properties
{
    public partial class PartialClassWithNestedClassWithSealedOverrideProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
