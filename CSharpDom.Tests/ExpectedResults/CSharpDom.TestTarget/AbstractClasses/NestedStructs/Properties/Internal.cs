namespace CSharpDom.TestTarget.AbstractClasses.NestedStructs.Properties
{
    public abstract class AbstractClassWithNestedStructWithInternalProperty
    {
        public struct Struct
        {
            internal string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
