namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties
{
    public struct StructWithNestedSealedClassWithPublicProperty
    {
        public sealed class Class
        {
            public string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
