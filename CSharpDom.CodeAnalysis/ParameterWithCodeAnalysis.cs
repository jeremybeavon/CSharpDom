using CSharpDom.BaseClasses;
using CSharpDom.CodeAnalysis.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CSharpDom.CodeAnalysis
{
    public sealed class ParameterWithCodeAnalysis :
        AbstractParameter<AttributeGroupWithCodeAnalysis, ITypeReferenceWithCodeAnalysis>,
        IHasParameterDefinition//,
        //IVisitable<IReflectionVisitor>
    {
        private static readonly Type[] excludedAttributeTypes = new Type[]
        {
            typeof(OutAttribute),
            typeof(ParamArrayAttribute)
        };
        private readonly AssemblyWithCodeAnalysis assembly;
        private readonly ParameterDefinition parameter;
        private readonly Lazy<Attributes> attributes;
        private readonly ITypeReferenceWithCodeAnalysis parameterType;

        internal ParameterWithCodeAnalysis(AssemblyWithCodeAnalysis assembly, ParameterDefinition parameter, MemberReference member)
        {
            this.assembly = assembly;
            this.parameter = parameter;
            attributes = new Lazy<Attributes>(() => new Attributes(assembly, parameter, excludedAttributeTypes));
            parameterType = TypeReferenceWithCodeAnalysisFactory.CreateReference(assembly, parameter.ParameterType, member);
        }

        public override IReadOnlyCollection<AttributeGroupWithCodeAnalysis> Attributes
        {
            get { return attributes.Value.AttributesWithCodeAnalysis; }
        }

        public override string Name
        {
            get { return parameter.Name; }
        }

        public override ITypeReferenceWithCodeAnalysis ParameterType
        {
            get { return parameterType; }
        }

        public ParameterDefinition ParameterDefinition
        {
            get { return parameter; }
        }

        internal ParameterModifier Modifier
        {
            get
            {
                if (parameter.IsOut)
                {
                    return ParameterModifier.Out;
                }

                if (parameter.ParameterType.IsByReference)
                {
                    return ParameterModifier.Ref;
                }

                if (parameter.IsDefined(assembly, typeof(ParamArrayAttribute)))
                {
                    return ParameterModifier.Params;
                }

                return ParameterModifier.None;
            }
        }

        /*public void Accept(IReflectionVisitor visitor)
        {
            visitor.VisitParameterWithCodeAnalysis(this);
        }

        public void AcceptChildren(IReflectionVisitor visitor)
        {
            AcceptChildren(new ForwardingGenericVisitor(visitor));
        }*/
    }
}
