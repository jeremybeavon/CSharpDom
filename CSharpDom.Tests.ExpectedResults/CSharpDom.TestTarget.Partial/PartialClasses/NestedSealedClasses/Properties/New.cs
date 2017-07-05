namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Properties
{
    public partial class PartialClassWithNestedSealedClassWithNewProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
