namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Constructors
{
    public class ClassWithNestedStructWithPrivateConstructor
    {
        public struct Struct
        {
            private Struct(string text)
            {
            }
        }
    }
}
