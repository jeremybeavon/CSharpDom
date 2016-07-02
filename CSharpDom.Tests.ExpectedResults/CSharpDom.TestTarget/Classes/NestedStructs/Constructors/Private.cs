namespace CSharpDom.TestTarget.Classes.NestedStructs.Constructors
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
