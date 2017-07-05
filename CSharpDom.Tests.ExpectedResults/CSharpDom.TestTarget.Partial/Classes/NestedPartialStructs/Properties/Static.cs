namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Properties
{
    public class ClassWithNestedStructWithStaticProperty
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
