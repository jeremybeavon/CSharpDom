namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties.AutoProperties
{
    public struct StructWithNestedAbstractClassWithNewStaticAutoProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new static string Property { get; set; }
        }
    }
}
