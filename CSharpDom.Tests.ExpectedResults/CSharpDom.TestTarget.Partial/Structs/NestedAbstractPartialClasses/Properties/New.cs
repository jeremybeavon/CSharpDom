namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Properties
{
    public struct StructWithNestedAbstractPartialClassWithNewProperty
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
