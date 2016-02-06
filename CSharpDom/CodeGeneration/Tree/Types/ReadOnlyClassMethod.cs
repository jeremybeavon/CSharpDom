using CSharpDom.BaseClasses;
using CSharpDom.Common;
using CSharpDom.NotSupported;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyClassMethod :
        AbstractClassMethod<
            AttributeGroupNotSupported,
            IClassType,
            ReadOnlyGenericParameterDeclaration,
            ReadOnlyTypeReference,
            ReadOnlyMethodParameter,
            ReadOnlyMethodBody>
    {
        private readonly ClassMethod method;
        private readonly ReadOnlyMethodBody body;
        private readonly IReadOnlyList<ReadOnlyGenericParameterDeclaration> genericParameters;
        private readonly IReadOnlyList<ReadOnlyMethodParameter> parameters;
        private readonly ReadOnlyTypeReference returnType;

        public ReadOnlyClassMethod(ClassMethod method)
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

        public override IClassType DeclaringType
        {
            get { return null; }
        }

        public override IReadOnlyList<ReadOnlyGenericParameterDeclaration> GenericParameters
        {
            get { return genericParameters; }
        }

        public override ClassMemberInheritanceModifier InheritanceModifier
        {
            get { return ReadOnlyClass.GetInheritanceModifier(method.InheritanceModifier); }
        }

        public override bool IsAsync
        {
            get { return method.IsAsync; }
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

        public override ClassMemberVisibilityModifier Visibility
        {
            get { return ReadOnlyClass.GetVisibility(method.Visibility); }
        }
    }
}
