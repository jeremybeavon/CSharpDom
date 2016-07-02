namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties
{
    public struct StructWithNestedAbstractClassWithStaticProperty
    {
        public abstract class Class
        {
            public static string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
