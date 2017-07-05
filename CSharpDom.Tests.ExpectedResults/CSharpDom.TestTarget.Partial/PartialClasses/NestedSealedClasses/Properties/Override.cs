namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Properties
{
    public partial class PartialClassWithNestedSealedClassWithOverrideProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
