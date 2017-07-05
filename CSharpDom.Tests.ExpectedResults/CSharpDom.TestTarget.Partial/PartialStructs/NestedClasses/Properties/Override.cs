namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Properties
{
    public partial struct PartialStructWithWithNestedClassWithOverrideProperty
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
