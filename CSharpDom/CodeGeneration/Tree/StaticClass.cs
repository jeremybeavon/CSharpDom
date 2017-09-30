﻿using System;
using System.Collections.ObjectModel;
using CSharpDom.Common;
using CSharpDom.NotSupported;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class StaticClass
    {
        public StaticClass(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            GenericParameters = new Collection<GenericParameter>();
            Interfaces = new Collection<InterfaceReference>();
            Body = new StaticClassBody();
            Visibility = TypeVisibilityModifier.Public;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public TypeVisibilityModifier Visibility { get; set; }
        
        public Collection<GenericParameter> GenericParameters { get; set; }

        public ClassReference BaseClass { get; set; }

        public Collection<InterfaceReference> Interfaces { get; set; }

        public StaticClassBody Body { get; set; }
    }
}
