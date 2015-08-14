﻿namespace CSharpDom.CodeGeneration.Tree
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
            if (visitor != null)
            {
                visitor.Visit(this);
            }
        }

        public override void AcceptChildren(CodeGenerationVisitor visitor)
        {
        }
    }
}
