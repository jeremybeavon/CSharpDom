﻿using Mono.Cecil;
using System;

namespace CSharpDom.Mono.Cecil
{
    public static class FieldDefinitionExtensions
    {
        public static bool IsVolatile(this FieldDefinition field)
        {
            return field.FullName.Contains("modreq(System.Runtime.CompilerServices.IsVolatile)");
        }
    }
}
