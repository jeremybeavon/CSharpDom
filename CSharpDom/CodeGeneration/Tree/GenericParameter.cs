﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDom.CodeGeneration.Tree
{
    public sealed class GenericParameter
    {
        public GenericParameter(string name)
        {
            Name = name;
            GenericParameterConstraints = new Collection<GenericParameterReference>();
            InterfaceConstraints = new Collection<InterfaceReference>();
        }

        public string Name { get; set; }

        public GenericParameteTypeConstraintModifier TypeConstraint { get; set; }

        public ClassReference BaseClassConstraint { get; set; }

        public Collection<GenericParameterReference> GenericParameterConstraints { get; set; }

        public Collection<InterfaceReference> InterfaceConstraints { get; set; }

        public bool HasEmptyConstructorConstraint { get; set; }
    }
}
