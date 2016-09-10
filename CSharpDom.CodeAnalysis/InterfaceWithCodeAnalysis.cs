using CSharpDom.Common;
using CSharpDom.Editable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeAnalysis
{
    public sealed class InterfaceWithCodeAnalysis :
        EditableInterface<
            INamespace,
            IDocument,
            IProject,
            ISolution,
            AttributeGroupWithCodeAnalysis,
            GenericParameterDeclarationWithCodeAnalysis,
            InterfaceReferenceWithCodeAnalysis,
            InterfaceEventWithCodeAnalysis,
            InterfacePropertyWithCodeAnalysis,
            InterfaceIndexerWithCodeAnalysis,
            InterfaceMethodWithCodeAnalysis>,
        IInterfaceTypeWithCodeAnalysis,
        IHasSyntax<InterfaceDeclarationSyntax>,
        IHasId//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly Guid internalId;
        private readonly InterfaceTypeWithCodeAnalysis type;

        private InterfaceWithCodeAnalysis()
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

        public override ICollection<InterfaceEventWithCodeAnalysis> Events
        {
            get { return type.Events; }
            set { type.Events = value; }
        }

        public override IList<GenericParameterDeclarationWithCodeAnalysis> GenericParameters
        {
            get { return type.GenericParameters; }
            set { type.GenericParameters = value; }
        }

        public override ICollection<InterfaceIndexerWithCodeAnalysis> Indexers
        {
            get { return type.Indexers; }
            set { type.Indexers = value; }
        }

        public override ICollection<InterfaceReferenceWithCodeAnalysis> Interfaces
        {
            get { return type.Interfaces; }
            set { type.Interfaces = value; }
        }
        
        public override ICollection<InterfaceMethodWithCodeAnalysis> Methods
        {
            get { return type.Methods; }
            set { type.Methods = value; }
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

        public override ICollection<InterfacePropertyWithCodeAnalysis> Properties
        {
            get { return type.Properties; }
            set { type.Properties = value; }
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

        public InterfaceDeclarationSyntax Syntax
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
            visitor.VisitInterfaceWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
