namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Properties.AutoProperties
{
    public struct StructWithNestedAbstractPartialClassWithNewStaticAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
