namespace CSharpDom.TestTarget.Partial.AbstractPartialClasses.NestedStructs.Constructors
{
    public abstract partial class AbstractPartialClassWithNestedStructWithPrivateConstructor
    {
        public struct Struct
        {
            private Struct(string text)
            {
            }
        }
    }
}
