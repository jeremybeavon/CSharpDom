namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties
{
    public struct StructWithNestedSealedClassWithNewStaticProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public new static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
