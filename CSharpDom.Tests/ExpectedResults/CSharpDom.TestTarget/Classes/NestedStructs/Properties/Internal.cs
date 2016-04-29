namespace CSharpDom.TestTarget.Classes.NestedStructs.Properties
{
    public class ClassWithNestedStructWithInternalProperty
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
