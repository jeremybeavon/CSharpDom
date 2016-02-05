﻿using System;
using System.Collections.Generic;
using CSharpDom.Common.Statements;

namespace CSharpDom.BaseClasses.Statements
{
    public abstract class AbstractBreakStatement : IBreakStatement
    {
        public void Accept(IGenericStatementVisitor visitor)
        {
            visitor.VisitBreakStatement(this);
        }

        public void AcceptChildren(IGenericStatementVisitor visitor)
        {
        }
    }
}