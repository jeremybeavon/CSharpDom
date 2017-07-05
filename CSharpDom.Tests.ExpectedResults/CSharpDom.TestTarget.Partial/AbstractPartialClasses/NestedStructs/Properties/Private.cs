namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Properties
{
    public abstract partial class AbstractPartialClassWithNestedStructWithPrivateProperty
    {
        public struct Struct
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
