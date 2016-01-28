using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public abstract class ReadOnlyClassMethod :
        AbstractMethod<
            AttributeGroupNotSupported,
            IBasicType,
            ReadOnlyGenericParameterDeclaration,
            ReadOnlyTypeReference,
            ReadOnlyClassMethodParameter,
            ReadOnlyMethodBody>
    {
        private readonly ClassMethod method;
        private readonly ReadOnlyMethodBody body;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly IReadOnlyList<ReadOnlyClassMethodParameter> parameters;
        private readonly ReadOnlyTypeReference returnType;

        public ReadOnlyClassMethod(ClassMethod method)
        {
            this.method = method;
            body = new ReadOnlyMethodBody(method.Body);
            genericParameters = ReadOnlyGenericParameterDeclaration.Create(method.GenericParameters);
            parameters = method.Parameters.Select(parameter => new ReadOnlyClassMethodParameter(parameter)).ToArray();
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

        public override IBasicType DeclaringType
        {
            get { return null; }
        }

        public override IReadOnlyList<ReadOnlyGenericParameterDeclaration> GenericParameters
        {
            get { return genericParameters; }
        }

        public override MemberInheritanceModifier InheritanceModifier
        {
            get { return ReadOnlyClass.InheritanceModifier(method.InheritanceModifier); }
        }

        public override string Name
        {
            get { return method.Name; }
        }

        public override IReadOnlyList<ReadOnlyClassMethodParameter> Parameters
        {
            get { return parameters; }
        }

        public override ReadOnlyTypeReference ReturnType
        {
            get { return returnType; }
        }

        public override MemberVisibilityModifier Visibility
        {
            get { return ReadOnlyClass.Visibility(method.Visibility); }
        }
    }
}
