namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties
{
    public struct StructWithNestedAbstractClassWithInternalProperty
    {
        public abstract class Class
        {
            internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
