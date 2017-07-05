namespace CSharpDom.TestTarget.Partial.SealedPartialClasses.NestedStructs.Constructors
{
    public sealed partial class SealedPartialClassWithNestedStructWithPrivateConstructor
    {
        public struct Struct
        {
            private Struct(string text)
            {
            }
        }
    }
}
