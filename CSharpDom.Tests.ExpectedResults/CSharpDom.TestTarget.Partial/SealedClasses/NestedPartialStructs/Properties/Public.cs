namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Properties
{
    public sealed class SealedClassWithNestedStructWithPublicProperty
    {
        public struct Struct
        {
            public string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
