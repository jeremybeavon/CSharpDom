namespace CSharpDom.TestTarget.Structs.NestedClasses.Properties
{
    public struct StructWithNestedClassWithOverrideProperty
    {
        public class Class : BaseClassWithProperty
        {
            public override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
