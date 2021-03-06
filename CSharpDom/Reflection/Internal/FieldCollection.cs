﻿using System;
using System.Collections.Generic;

namespace CSharpDom.Reflection.Internal
{
    internal sealed class FieldCollection<TField, TConstant, TType>
        where TType : ITypeWithReflection
    {
        private readonly Lazy<Fields<TField, TConstant, TType>> fields;

        public FieldCollection(Func<Fields<TField, TConstant, TType>> fields)
        {
            this.fields = new Lazy<Fields<TField, TConstant, TType>>(fields);
        }

        public Fields<TField, TConstant, TType> Fields
        {
            get { return fields.Value; }
        }
    }
}
