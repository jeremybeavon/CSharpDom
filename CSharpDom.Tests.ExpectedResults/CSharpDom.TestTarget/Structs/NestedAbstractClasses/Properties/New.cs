namespace CSharpDom.TestTarget.Structs.NestedAbstractClasses.Properties
{
    public struct StructWithNestedAbstractClassWithNewProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public new string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
