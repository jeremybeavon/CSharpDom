﻿using System.Collections.ObjectModel;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class AbstractProperty
    {
        public AbstractProperty(string name)
        {
            Name = name;
            Attributes = new Collection<AttributeGroup>();
            Visibility = ClassMemberVisibilityModifier.Public;
        }

        public Collection<AttributeGroup> Attributes { get; set; }

        public string Name { get; set; }

        public ClassMemberVisibilityModifier Visibility { get; set; }
        
        public TypeReference Type { get; set; }

        public EmptyClassPropertyAccessors EmptyAccessors { get; set; }
    }
}
