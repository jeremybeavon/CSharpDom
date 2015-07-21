﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class EmptyClassPropertyAccessors : CodeGenerationNode
    {
        public EmptyClassPropertyAccessors()
        {
        }

        public EmptyClassPropertyAccessors(
            ClassPropertyAccessorVisibilityModifier getAccessorVisibility,
            ClassPropertyAccessorVisibilityModifier setAccessorVisibility)
        {
            getAccessorVisibility = GetAccessorVisibility;
            SetAccessorVisibility = setAccessorVisibility;
        }

        public ClassPropertyAccessorVisibilityModifier GetAccessorVisibility { get; set; }

        public ClassPropertyAccessorVisibilityModifier SetAccessorVisibility { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
