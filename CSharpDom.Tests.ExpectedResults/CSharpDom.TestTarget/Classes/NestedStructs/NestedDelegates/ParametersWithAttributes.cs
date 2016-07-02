namespace CSharpDom.TestTarget.Classes.NestedStructs.NestedDelegates
{
    public class ClassWithNestedStructWithNestedClassWithNestedDelegateWithParametersWithAttributes
    {
        public struct Struct
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
