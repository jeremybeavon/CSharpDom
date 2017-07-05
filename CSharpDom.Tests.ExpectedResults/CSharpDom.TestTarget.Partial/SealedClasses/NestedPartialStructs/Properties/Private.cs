namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Properties
{
    public sealed class SealedClassWithNestedStructWithPrivateProperty
    {
        public struct Struct
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
