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
    public sealed class ReadOnlyClassMethodParameter : AbstractParameter<AttributeGroupNotSupported, ReadOnlyTypeReference>
    {
        private readonly ClassMethodParameter parameter;
        private readonly ReadOnlyTypeReference parameterType;

        public ReadOnlyClassMethodParameter(ClassMethodParameter parameter)
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
                    case ClassMethodParameterModifier.None:
                        return ParameterModifier.None;
                    case ClassMethodParameterModifier.Out:
                        return ParameterModifier.Out;
                    case ClassMethodParameterModifier.Params:
                        return ParameterModifier.Params;
                    case ClassMethodParameterModifier.Ref:
                        return ParameterModifier.Ref;
                    case ClassMethodParameterModifier.This:
                        return ParameterModifier.This;
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
    }
}
