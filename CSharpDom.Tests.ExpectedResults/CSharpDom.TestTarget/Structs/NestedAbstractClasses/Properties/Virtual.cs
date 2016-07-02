namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties
{
    public struct StructWithNestedAbstractClassWithVirtualProperty
    {
        public abstract class Class
        {
            public virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
