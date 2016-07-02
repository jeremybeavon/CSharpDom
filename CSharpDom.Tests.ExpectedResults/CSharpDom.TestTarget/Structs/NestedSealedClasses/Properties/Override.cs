namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties
{
    public struct StructWithNestedSealedClassWithOverrideProperty
    {
        public sealed class Class : BaseClassWithProperty
        {
            public override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
