using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyDelegate :
        AbstractDelegate<
            NamespaceNotSupported,
            DocumentNotSupported,
            ProjectNotSupported,
            SolutionNotSupported,
            AttributeGroupNotSupported,
            ReadOnlyGenericParameterDeclaration,
            ReadOnlyTypeReference,
            ReadOnlyDelegateParameter>
    {
        private readonly Delegate @delegate;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly IReadOnlyList<ReadOnlyDelegateParameter> parameters;
        private readonly ReadOnlyTypeReference returnType;

        public ReadOnlyDelegate(Delegate @delegate)
        {
            this.@delegate = @delegate;
            genericParameters = ReadOnlyGenericParameterDeclaration.Create(@delegate.GenericParameters);
            parameters = ReadOnlyDelegateParameter.Create(@delegate.Parameters);
            returnType = new ReadOnlyTypeReference(@delegate.ReturnType);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override DocumentNotSupported Document
        {
            get { return new DocumentNotSupported(); }
        }

        public override IReadOnlyList<ReadOnlyGenericParameterDeclaration> GenericParameters
        {
            get { return genericParameters; }
        }

        public override string Name
        {
            get { return @delegate.Name; }
        }

        public override NamespaceNotSupported Namespace
        {
            get { return new NamespaceNotSupported(); }
        }

        public override IReadOnlyList<ReadOnlyDelegateParameter> Parameters
        {
            get { return parameters; }
        }

        public override ProjectNotSupported Project
        {
            get { return new ProjectNotSupported(); }
        }

        public override ReadOnlyTypeReference ReturnType
        {
            get { return returnType; }
        }

        public override SolutionNotSupported Solution
        {
            get { return new SolutionNotSupported(); }
        }

        public override TypeVisibilityModifier Visibility
        {
            get { return @delegate.Visibility; }
        }
    }
}
