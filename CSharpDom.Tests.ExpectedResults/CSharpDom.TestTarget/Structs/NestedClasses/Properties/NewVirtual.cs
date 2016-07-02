namespace CSharpDom.TestTarget.Structs.NestedClasses.Properties
{
    public struct StructWithNestedClassWithNewVirtualProperty
    {
        public class Class : BaseClassWithProperty
        {
            public new virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
