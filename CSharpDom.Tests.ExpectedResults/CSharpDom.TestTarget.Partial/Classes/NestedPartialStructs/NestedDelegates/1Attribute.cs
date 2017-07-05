namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.NestedDelegates
{
    public class ClassWithNestedStructWithNestedDelegateWith1Attribute
    {
        public struct Struct
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
