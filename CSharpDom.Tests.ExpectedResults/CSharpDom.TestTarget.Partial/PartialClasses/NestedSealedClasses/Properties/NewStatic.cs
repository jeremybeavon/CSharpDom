namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Properties
{
    public partial class PartialClassWithNestedSealedClassWithNewStaticProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
