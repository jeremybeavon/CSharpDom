using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassMethod :
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
            parameters = method.Parameters.ToArray(parameter => new ReadOnlyClassMethodParameter(parameter));
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
            get { return ReadOnlyClass.GetInheritanceModifier(method.InheritanceModifier); }
        }

        public override bool IsAsync
        {
            get { return method.IsAsync; }
        }

        public override bool IsPartial
        {
            get { return method.IsPartial; }
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
            get { return ReadOnlyClass.GetVisibility(method.Visibility); }
        }
    }
}
