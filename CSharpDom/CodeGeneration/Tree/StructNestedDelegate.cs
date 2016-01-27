﻿using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructNestedDelegate
    {
        public StructNestedDelegate(string name)
        {
            Name = name;
            GenericParameters = new Collection<GenericParameter>();
            Parameters = new Collection<MethodParameter>();
        }

        public StructMemberVisibilityModifier Visibility { get; set; }

        public string Name { get; set; }

        public TypeReference ReturnType { get; set; }

        public Collection<GenericParameter> GenericParameters { get; set; }

        public Collection<MethodParameter> Parameters { get; set; }
    }
}
