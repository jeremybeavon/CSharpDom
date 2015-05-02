﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.WithLinqExpressions.Internal
{
    internal static class VisitorExtensions
    {
        public static IEnumerable<ILinqExpressionMapping> Accept(
            this SeparatedSyntaxList<ExpressionSyntax> node,
            CSharpSyntaxVisitor<ILinqExpressionMapping> visitor)
        {
            return node.Select(childNode => childNode.Accept(visitor));
        }
    }
}
