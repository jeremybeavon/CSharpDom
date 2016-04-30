namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.Constructors
{
    public sealed class SealedClassWithNestedStructWithPrivateConstructor
    {
        public struct Struct
        {
            private Struct(string text)
            {
            }
        }
    }
}
