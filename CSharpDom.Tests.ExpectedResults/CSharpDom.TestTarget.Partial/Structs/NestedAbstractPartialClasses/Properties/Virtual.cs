namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Properties
{
    public struct StructWithNestedAbstractPartialClassWithVirtualProperty
    {
        public abstract partial class Class
        {
            public virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
