﻿using System;
using System.Collections.Generic;
using CSharpDom.BaseClasses;
using CSharpDom.Reflection.Internal;

namespace CSharpDom.Reflection
{
    public sealed class UnspecifiedTypeReferenceWithReflection :
        AbstractUnspecifiedTypeReference<GenericParameterWithReflection>,
        ITypeReferenceWithReflection
    {
        private readonly Type type;
        private readonly Lazy<GenericParameters> genericParameters;

        internal UnspecifiedTypeReferenceWithReflection(Type type)
        {
            this.type = type;
            genericParameters = new Lazy<GenericParameters>(() => new GenericParameters(type));
        }

        public override IReadOnlyList<GenericParameterWithReflection> GenericParameters
        {
            get { return genericParameters.Value.GenericParametersWithReflection; }
        }

        public override string Name
        {
            get { return type.Name; }
        }
    }
}
