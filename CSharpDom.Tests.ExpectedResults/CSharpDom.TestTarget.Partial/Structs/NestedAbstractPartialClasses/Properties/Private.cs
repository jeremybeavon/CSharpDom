namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Properties
{
    public struct StructWithNestedAbstractPartialClassWithPrivateProperty
    {
        public abstract partial class Class
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
