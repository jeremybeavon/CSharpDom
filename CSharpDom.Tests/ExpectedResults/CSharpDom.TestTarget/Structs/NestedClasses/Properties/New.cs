namespace CSharpDom.TestTarget.Structs.NestedClasses.Properties
{
    public struct StructWithNestedClassWithNewProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
