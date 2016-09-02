using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class MemberWithCodeAnalysis :
        IHasSyntax<MemberDeclarationSyntax>,
        IHasId
    {
        public Guid InternalId
        {
            get { return Guid.NewGuid(); }
        }

        public MemberDeclarationSyntax Syntax
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
