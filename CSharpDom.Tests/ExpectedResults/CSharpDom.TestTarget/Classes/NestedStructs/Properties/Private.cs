namespace CSharpDom.TestTarget.Classes.NestedStructs.Properties
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
