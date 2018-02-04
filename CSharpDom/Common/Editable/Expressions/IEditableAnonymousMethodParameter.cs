using CSharpDom.Common.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.Common.Editable.Expressions
{
    public interface IEditableAnonymousMethodParameter : IVisitable<IEditableExpressionVisitor>, IAnonymousMethodParameter
    {
    }
}