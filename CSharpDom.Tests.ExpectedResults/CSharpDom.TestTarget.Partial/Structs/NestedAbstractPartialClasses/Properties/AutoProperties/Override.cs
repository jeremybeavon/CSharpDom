namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Properties.AutoProperties
{
    public struct StructWithNestedAbstractPartialClassWithOverrideAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public override string Property { get; set; }
        }
    }
}
