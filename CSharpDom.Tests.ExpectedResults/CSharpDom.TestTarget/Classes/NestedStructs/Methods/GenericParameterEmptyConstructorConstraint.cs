﻿namespace CSharpDom.TestTarget.Classes.NestedStructs.Methods
{
    public class ClassWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraint
    {
        public struct Struct
        {
            public T Method<T>()
                where T : new()
            {
                return default(T);
            }
        }
    }
}
