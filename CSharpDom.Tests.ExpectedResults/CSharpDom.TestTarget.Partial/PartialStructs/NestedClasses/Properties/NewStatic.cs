namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Properties
{
    public partial struct PartialStructWithWithNestedClassWithNewStaticProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
