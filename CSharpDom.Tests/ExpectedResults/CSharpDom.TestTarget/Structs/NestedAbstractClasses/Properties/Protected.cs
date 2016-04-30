namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties
{
    public struct StructWithNestedAbstractClassWithProtectedProperty
    {
        public abstract class Class
        {
            protected string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
