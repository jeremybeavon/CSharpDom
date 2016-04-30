namespace CSharpDom.TestTarget.Structs.NestedClasses.Properties
{
    public struct StructWithNestedClassWithNewStaticProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
