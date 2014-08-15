using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom
{
    internal interface IPropertyModifier<TProperty> : IMemberModifier<TProperty>
    {
        TProperty WithAccessors(TProperty property, AccessorListSyntax accessors);
    }
}
