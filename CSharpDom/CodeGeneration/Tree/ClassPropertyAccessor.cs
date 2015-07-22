﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class ClassPropertyAccessor : CodeGenerationNode
    {
        public ClassPropertyAccessor()
        {
            Body = new Collection<Statement>();
        }

        public ClassPropertyAccessorVisibilityModifier Visibility { get; set; }

        public Collection<Statement> Body { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
