using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using CSharpDom.CodeAnalysis.Internal;
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ConversionOperatorWithCodeAnalysis :
        AbstractConversionOperator<
            AttributeGroupWithCodeAnalysis,
            ITypeWithCodeAnalysis,
            ITypeReferenceWithCodeAnalysis,
            OperatorParameterWithCodeAnalysis,
            MethodBodyWithCodeAnalysis>,
        IHasMethodDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private readonly ITypeWithCodeAnalysis declaringType;
        private readonly MethodDefinition method;
        private readonly Lazy<Attributes> attributes;
        private readonly OperatorParameterWithCodeAnalysis parameter;
        private readonly ITypeReferenceWithCodeAnalysis returnType;
        private readonly Lazy<Attributes> returnAttributes;
        private readonly Lazy<MethodBodyWithCodeAnalysis> body;

        internal ConversionOperatorWithCodeAnalysis(ITypeWithCodeAnalysis declaringType, MethodDefinition method)
        {
            this.declaringType = declaringType;
            this.method = method;
            AssemblyWithCodeAnalysis assembly = declaringType.Assembly;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, method));
            parameter = new OperatorParameterWithCodeAnalysis(new ParameterWithCodeAnalysis(assembly, method.Parameters[0], method));
            returnType = TypeReferenceWithCodeAnalysisFactory.CreateReference(declaringType.Assembly, method.ReturnType, method);
            returnAttributes = new Lazy<Attributes>(() => new Attributes(assembly, method.MethodReturnType));
            body = new Lazy<MethodBodyWithCodeAnalysis>(() => new MethodBodyWithCodeAnalysis(method));
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override ITypeWithCodeAnalysis DeclaringType
        {
            get { return declaringType; }
        }

        public override ConversionOperatorType OperatorType
        {
            get
            {
                switch (method.Name)
                {
                    case "op_Implicit":
                        return ConversionOperatorType.Implicit;
                    case "op_Explicit":
                        return ConversionOperatorType.Explicit;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        public override OperatorParameterWithCodeAnalysis Parameter
        {
            get { return parameter; }
        }
        
        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> ReturnAttributes
        {
            get { return returnAttributes.Value.AttributesWithCodeAnalysis; }
        }

        public override ITypeReferenceWithCodeAnalysis ReturnType
        {
            get { return returnType; }
        }

        public MethodDefinition MethodDefinition
        {
            get { return method; }
        }

        public override MethodBodyWithCodeAnalysis Body
        {
            get { return body.Value; }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitConversionOperatorWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
