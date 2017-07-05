namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Properties
{
    public partial struct PartialStructWithWithNestedClassWithNewVirtualProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
