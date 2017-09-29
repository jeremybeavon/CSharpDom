namespace CSharpDom.TestTarget.Partial.PartialStructs.NestedAbstractClasses.Properties.AutoProperties
{
    public partial struct PartialStructWithNestedAbstractClassWithNewAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
