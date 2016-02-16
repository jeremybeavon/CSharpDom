using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyStaticClassMethod :
        AbstractStaticClassMethod<
            AttributeGroupNotSupported,
            IStaticType,
            ReadOnlyGenericParameterDeclaration,
            ReadOnlyTypeReference,
            ReadOnlyMethodParameter,
            ReadOnlyMethodBody>
    {
        private readonly StaticClassMethod method;
        private readonly ReadOnlyMethodBody body;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly IReadOnlyList<ReadOnlyMethodParameter> parameters;
        private readonly ReadOnlyTypeReference returnType;

        public ReadOnlyStaticClassMethod(StaticClassMethod method)
        {
            this.method = method;
            if (method.Body.Count != 0)
            {
                body = new ReadOnlyMethodBody(method.Body);
            }

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

        public override IStaticType DeclaringType
        {
            get { return null; }
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

        public override StaticClassMemberVisibilityModifier Visibility
        {
            get { return method.Visibility; }
        }

        public override bool IsAsync
        {
            get { return method.IsAsync; }
        }
    }
}
