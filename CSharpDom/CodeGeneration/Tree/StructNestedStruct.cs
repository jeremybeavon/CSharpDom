﻿using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StructNestedStruct
    {
        public StructNestedStruct(string name)
        {
            Name = name;
            Body = new StructBody();
            GenericParameters = new Collection<GenericParameter>();
            Interfaces = new Collection<InterfaceReference>();
        }

        public string Name { get; set; }

        public StructMemberVisibilityModifier Visibility { get; set; }
        
        public bool IsPartial { get; set; }

        public Collection<GenericParameter> GenericParameters { get; set; }

        public Collection<InterfaceReference> Interfaces { get; set; }

        public StructBody Body { get; set; }
    }
}
