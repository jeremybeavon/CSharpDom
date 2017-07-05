namespace CSharpDom.TestTarget.Partial.PartialClasses.NestedSealedClasses.Properties
{
    public partial class PartialClassWithNestedSealedClassWithSealedOverrideProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
