using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyExplicitInterfaceMethod :
        AbstractExplicitInterfaceMethod<
            AttributeGroupNotSupported,
            IType,
            ReadOnlyInterfaceReference,
            ReadOnlyGenericParameterDeclaration,
            ReadOnlyTypeReference,
            ReadOnlyMethodParameter,
            ReadOnlyMethodBody>
    {
        private readonly ExplicitInterfaceMethod method;
        private readonly ReadOnlyInterfaceReference explicitInterface;
        private readonly ReadOnlyMethodBody body;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly IReadOnlyList<ReadOnlyMethodParameter> parameters;
        private readonly ReadOnlyTypeReference returnType;

        public ReadOnlyExplicitInterfaceMethod(ExplicitInterfaceMethod method)
        {
            this.method = method;
            explicitInterface = new ReadOnlyInterfaceReference(method.ExplicitInterface);
            body = new ReadOnlyMethodBody(method.Body);
            genericParameters = ReadOnlyGenericParameterDeclaration.Create(method.GenericParameters);
            parameters = method.Parameters.ToArray(parameter => new ReadOnlyMethodParameter(parameter));
            returnType = new ReadOnlyTypeReference(method.ReturnType);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override ReadOnlyMethodBody Body
        {
            get { return body; }
        }

        public override IType DeclaringType
        {
            get { return null; }
        }

        public override ReadOnlyInterfaceReference ExplicitInterface
        {
            get { return explicitInterface; }
        }

        public override IReadOnlyList<ReadOnlyGenericParameterDeclaration> GenericParameters
        {
            get { return genericParameters; }
        }
        
        public override string Name
        {
            get { return method.Name; }
        }

        public override IReadOnlyList<ReadOnlyMethodParameter> Parameters
        {
            get { return parameters; }
        }

        public override ReadOnlyTypeReference ReturnType
        {
            get { return returnType; }
        }

        public override bool IsAsync
        {
            get { return method.IsAsync; }
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> ReturnAttributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }
    }
}
