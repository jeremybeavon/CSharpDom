namespace CSharpDom.TestTarget.Partial.SealedClasses.NestedStructs.Properties
{
    public sealed class SealedClassWithNestedStructWithStaticProperty
    {
        public struct Struct
        {
            public static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
