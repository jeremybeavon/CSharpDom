namespace CSharpDom.TestTarget.Partial.Structs.NestedAbstractPartialClasses.Properties
{
    public struct StructWithNestedAbstractPartialClassWithOverrideProperty
    {
        public abstract class Class : BaseClassWithProperty
        {
            public override string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
