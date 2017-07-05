namespace CSharpDom.TestTarget.Partial.Classes.NestedStructs.Methods
{
    public class ClassWithNestedStructWithMethodWithParametersWithModifiers
    {
        public struct Struct
        {
            public void Method(ref string parameter1, out string parameter2, params string[] parameters)
            {
                parameter2 = default(string);
            }
        }
    }
}
