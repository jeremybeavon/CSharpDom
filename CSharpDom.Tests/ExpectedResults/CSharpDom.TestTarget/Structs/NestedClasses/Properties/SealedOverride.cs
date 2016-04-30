namespace CSharpDom.TestTarget.Structs.NestedClasses.Properties
{
    public struct StructWithNestedClassWithSealedOverrideProperty
    {
        public class Class : BaseClassWithProperty
        {
            public sealed override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
