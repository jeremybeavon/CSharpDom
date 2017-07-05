namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Properties
{
    public abstract partial class AbstractPartialClassWithNestedStructWithInternalProperty
    {
        public struct Struct
        {
            internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
