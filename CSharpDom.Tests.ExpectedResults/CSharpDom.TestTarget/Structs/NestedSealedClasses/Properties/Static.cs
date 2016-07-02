namespace CSharpDom.TestTarget.Structs.NestedSealedClasses.Properties
{
    public struct StructWithNestedSealedClassWithStaticProperty
    {
        public sealed class Class
        {
            public static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
