﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class WhileStatement : Statement
    {
        public IExpressionStatement Condition { get; set; }

        public Statement Statement { get; set; }

        public override void Accept(CodeGenerationVisitor visitor)
        {
            throw new NotImplementedException();
        }
    }
}
