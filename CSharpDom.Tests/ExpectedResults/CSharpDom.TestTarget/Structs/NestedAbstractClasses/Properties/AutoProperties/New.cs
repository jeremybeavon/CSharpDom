namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties.AutoProperties
{
    public struct StructWithNestedAbstractClassWithNewAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new string Property { get; set; }
        }
    }
}
