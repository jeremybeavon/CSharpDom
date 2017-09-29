namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedClasses.Properties.AutoProperties
{
    public partial struct PartialStructWithNestedClassWithNewStaticAutoProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
