namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Properties
{
    public struct StructWithNestedPartialClassWithVirtualProperty
    {
        public partial class Class
        {
            public virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
