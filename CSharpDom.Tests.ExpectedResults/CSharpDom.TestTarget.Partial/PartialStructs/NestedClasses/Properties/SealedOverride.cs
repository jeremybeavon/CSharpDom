namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Properties
{
    public partial struct PartialStructWithWithNestedClassWithSealedOverrideProperty
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
