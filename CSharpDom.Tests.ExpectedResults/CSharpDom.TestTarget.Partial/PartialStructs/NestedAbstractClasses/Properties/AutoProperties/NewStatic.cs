namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Properties.AutoProperties
{
    public partial struct PartialStructWithWithNestedAbstractClassWithNewStaticAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
