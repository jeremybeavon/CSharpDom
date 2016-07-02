namespace CSharpDom.TestTarget.StaticClasses.NestedClasses.NestedDelegates
{
    public static class StaticClassWithNestedClassWithNestedDelegateWith2AttributesIn1AttributeGroup
    {
        public class Class
        {
            [Attribute1, Attribute2]
            public delegate void DelegateWith2AttributesIn1AttributeGroup();
        }
    }
}
