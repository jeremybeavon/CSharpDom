using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeAnalysis
{
    public sealed class DelegateWithCodeAnalysis :
        EditableDelegate<
            INamespace,
            IDocument,
            IProject,
            ISolution,
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            DelegateParameterWithCodeAnalysis>,
        IHasSyntax<DelegateDeclarationSyntax>,
        IHasId//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Guid internalId;
        private readonly DelegateTypeWithCodeAnalysis type;

        private DelegateWithCodeAnalysis()
        {
            internalId = Guid.NewGuid();
        }

        public override ICollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return type.Attributes; }
            set { type.Attributes = value; }
        }

        public override IDocument Document
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

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return type.GenericParameters; }
            set { type.GenericParameters = value; }
        }

        public override string Name
        {
            get { return type.Name; }
            set { type.Name = value; }
        }

        public override INamespace Namespace
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

        public override IList<DelegateParameterWithCodeAnalysis> Parameters
        {
            get { return type.Parameters; }
            set { type.Parameters = value; }
        }

        public override IProject Project
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

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return type.ReturnType; }
            set { type.ReturnType = value; }
        }

        public override ISolution Solution
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

        public DelegateDeclarationSyntax Syntax
        {
            get { return type.Syntax; }
            set { type.Syntax = value; }
        }

        public override TypeVisibilityModifier Visibility
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

        Guid IHasId.InternalId
        {
            get { return internalId; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitDelegateWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
