namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Properties
{
    public struct StructWithNestedAbstractPartialClassWithProtectedProperty
    {
        public abstract partial class Class
        {
            protected string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
