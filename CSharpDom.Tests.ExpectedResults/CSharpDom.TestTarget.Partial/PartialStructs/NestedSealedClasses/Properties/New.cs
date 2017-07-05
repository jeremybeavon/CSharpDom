namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedSealedClasses.Properties
{
    public partial struct PartialStructWithWithNestedSealedClassWithNewProperty
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
