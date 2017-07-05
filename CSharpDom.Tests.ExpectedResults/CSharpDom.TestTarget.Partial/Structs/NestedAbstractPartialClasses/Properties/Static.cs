namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Properties
{
    public struct StructWithNestedAbstractPartialClassWithStaticProperty
    {
        public abstract partial class Class
        {
            public static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
