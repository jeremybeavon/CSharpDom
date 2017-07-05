namespace CSharpDom.TestTarget.Partial.Structs.NestedPartialClasses.Properties
{
    public struct StructWithNestedPartialClassWithNewStaticProperty
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
