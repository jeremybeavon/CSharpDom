﻿using CSharpDom.BaseClasses;
using CSharpDom.NotSupported;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.CodeGeneration.Tree.Types
{
    public sealed class ReadOnlyMethodParameter : AbstractParameter<AttributeGroupNotSupported, ReadOnlyTypeReference>
    {
        private readonly MethodParameter parameter;
        private readonly ReadOnlyTypeReference parameterType;

        public ReadOnlyMethodParameter(MethodParameter parameter)
        {
            this.parameter = parameter;
            parameterType = new ReadOnlyTypeReference(parameter.Type);
        }

        public override IReadOnlyCollection<AttributeGroupNotSupported> Attributes
        {
            get { return new AttributeGroupNotSupported[0]; }
        }

        public override ParameterModifier Modifier
        {
            get
            {
                switch (parameter.Modifier)
                {
                    case MethodParameterModifier.None:
                        return ParameterModifier.None;
                    case MethodParameterModifier.Out:
                        return ParameterModifier.Out;
                    case MethodParameterModifier.Params:
                        return ParameterModifier.Params;
                    case MethodParameterModifier.Ref:
                        return ParameterModifier.Ref;
                    default:
                        throw new NotSupportedException();
                }
            }
        }

        public override string Name
        {
            get { return parameter.Name; }
        }

        public override ReadOnlyTypeReference ParameterType
        {
            get { return parameterType; }
        }

        public static IReadOnlyList<ReadOnlyMethodParameter> Create(IEnumerable<MethodParameter> parameters)
        {
            return parameters.ToArray(parameter => new ReadOnlyMethodParameter(parameter));
        }
    }
}