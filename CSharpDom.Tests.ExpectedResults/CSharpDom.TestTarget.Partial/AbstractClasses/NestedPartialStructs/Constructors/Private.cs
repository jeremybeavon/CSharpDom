namespace CSharpDom.TestTarget.Partial.AbstractClasses.NestedStructs.Constructors
{
    public abstract class AbstractClassWithNestedStructWithPrivateConstructor
    {
        public struct Struct
        {
            private Struct(string text)
            {
            }
        }
    }
}
