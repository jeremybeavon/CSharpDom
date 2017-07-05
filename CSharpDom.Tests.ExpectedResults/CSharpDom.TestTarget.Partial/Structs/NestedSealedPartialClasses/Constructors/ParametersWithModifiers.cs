namespace CSharpDom.TestTarget.Partial.Structs.NestedSealedPartialClasses.Constructors
{
    public struct StructWithNestedSealedPartialClassWithConstructorWithParametersWithModifiers
    {
        public sealed partial class Class
        {
            public Class(ref string text, out int integer, params object[] objects)
            {
                integer = default(int);
            }
        }
    }
}
