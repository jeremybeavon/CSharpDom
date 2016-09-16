using System;
using System.Collections.Generic;
using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis;

namespace CSharpDom.CodeAnalysis
{
    public sealed class SolutionWithCodeAnalysis :
        EditableSolution<ProjectWithCodeAnalysis>,
        IHasSyntax<Solution>,
        IHasNode<Solution>
    {
        private readonly Node<SolutionWithCodeAnalysis, Solution> node;


        public override ICollection<ProjectWithCodeAnalysis> Projects
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

        public Solution Syntax
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

        INode<Solution> IHasNode<Solution>.Node
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
