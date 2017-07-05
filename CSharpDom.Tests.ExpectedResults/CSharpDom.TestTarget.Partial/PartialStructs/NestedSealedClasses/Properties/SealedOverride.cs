namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Properties
{
    public partial struct PartialStructWithWithNestedSealedClassWithSealedOverrideProperty
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
