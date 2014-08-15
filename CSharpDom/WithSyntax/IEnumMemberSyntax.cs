using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDom.Common;

namespace CSharpDom.WithSyntax
{
    public interface IEnumMemberSyntax : IEnumMember,
        IHasDeclaringType<IEnumSyntax>
    {
        void Accept(ISyntaxVisitor visitor);
    }
}
