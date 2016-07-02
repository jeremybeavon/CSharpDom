namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties.AutoProperties
{
    public struct StructWithNestedAbstractClassWithOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
