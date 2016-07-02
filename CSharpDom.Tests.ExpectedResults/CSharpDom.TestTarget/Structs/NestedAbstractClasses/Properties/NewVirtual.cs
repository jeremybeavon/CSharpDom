namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties
{
    public struct StructWithNestedAbstractClassWithNewVirtualProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new virtual string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
