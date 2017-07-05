namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Properties
{
    public abstract class AbstractClassWithNestedStructWithStaticProperty
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
