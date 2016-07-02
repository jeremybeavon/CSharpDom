namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties
{
    public struct StructWithNestedSealedClassWithSealedOverrideProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
