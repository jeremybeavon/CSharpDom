namespace CSharpDom.TestTarget.Structs.NestedClasses.NestedDelegates
{
    public struct StructWithNestedClassWithNestedDelegateWith1Attribute
    {
        public class Class
        {
            [Attribute1]
            public delegate void DelegateWith1Attribute();
        }
    }
}
