namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Properties
{
    public abstract class AbstractClassWithNestedStructWithPrivateProperty
    {
        public struct Struct
        {
            private string Property
            {
                get { return default(string); }
                set { }
            }
        }
    }
}
