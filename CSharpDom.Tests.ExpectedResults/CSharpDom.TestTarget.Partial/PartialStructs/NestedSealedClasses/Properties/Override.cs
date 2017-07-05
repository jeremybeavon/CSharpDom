namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Properties
{
    public partial struct PartialStructWithWithNestedSealedClassWithOverrideProperty
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
