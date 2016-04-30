namespace CSharpDom.TestTarget.Structs.NestedClasses.Properties
{
    public struct StructWithNestedClassWithPrivateProperty
    {
        public class Class
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
