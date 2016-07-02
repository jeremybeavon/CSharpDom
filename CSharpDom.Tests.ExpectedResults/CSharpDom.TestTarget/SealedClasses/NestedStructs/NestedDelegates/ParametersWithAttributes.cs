namespace CSharpDom.TestTarget.SealedClasses.NestedStructs.NestedDelegates
{
    public sealed class SealedClassWithNestedStructWithNestedClassWithNestedDelegateWithParametersWithAttributes
    {
        public struct Struct
        {
            public delegate void DelegateWithParametersWithAttributes([Attribute1]string parameter1, [Attribute2][Attribute3]string parameter2);
        }
    }
}
