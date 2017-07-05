namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Properties
{
    public sealed class SealedClassWithNestedStructWithInternalProperty
    {
        public struct Struct
        {
            internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
