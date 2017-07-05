namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Properties
{
    public class ClassWithNestedStructWithPrivateProperty
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
