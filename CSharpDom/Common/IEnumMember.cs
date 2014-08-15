﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.Common
{
    public interface IEnumMember : IHasName, IHasDeclaration<EnumMemberDeclarationSyntax>, IHasLocation
    {
    }
}
