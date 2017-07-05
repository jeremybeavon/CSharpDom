namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Properties
{
    public partial struct PartialStructWithWithNestedClassWithNewProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
