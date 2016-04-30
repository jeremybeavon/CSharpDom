namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.Properties
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
