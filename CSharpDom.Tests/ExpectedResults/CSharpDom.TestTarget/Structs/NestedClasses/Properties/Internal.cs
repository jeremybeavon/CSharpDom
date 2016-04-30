namespace CSharpDom.TestTarget.Structs.NestedClasses.Properties
{
    public struct StructWithNestedClassWithInternalProperty
    {
        public class Class
        {
            internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
