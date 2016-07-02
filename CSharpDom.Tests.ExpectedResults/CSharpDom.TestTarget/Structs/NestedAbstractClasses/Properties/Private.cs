namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties
{
    public struct StructWithNestedAbstractClassWithPrivateProperty
    {
        public abstract class Class
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
