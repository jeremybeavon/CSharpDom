namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Properties
{
    public abstract partial class AbstractPartialClassWithNestedStructWithStaticProperty
    {
        public struct Struct
        {
            public static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
