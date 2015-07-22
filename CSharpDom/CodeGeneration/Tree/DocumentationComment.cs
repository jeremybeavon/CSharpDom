﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class DocumentationComment : CodeGenerationNode
    {
        public DocumentationComment(string comment)
        {
            Comment = comment;
        }

        public string Comment { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}