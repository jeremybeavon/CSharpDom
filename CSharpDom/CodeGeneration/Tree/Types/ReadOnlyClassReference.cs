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
    public sealed class ReadOnlyClassReference : AbstractClassReference<ReadOnlyGenericParameter>
    {
        private readonly string name;
        private readonly IReadOnlyList<ReadOnlyGenericParameter> genericParameters;

        public ReadOnlyClassReference(ClassReference classReference)
        {
            genericParameters = ReadOnlyGenericParameter.Create(classReference.GenericParameters);
            if (!string.IsNullOrWhiteSpace(classReference.TypeText))
            {
                name = classReference.TypeText;
            }
            else if (classReference.Class != null)
            {
                name = classReference.Class.Name;
            }
            else if (classReference.ClassNestedClass != null)
            {
                name = classReference.ClassNestedClass.Name;
            }
            else if (classReference.StructNestedClass != null)
            {
                name = classReference.StructNestedClass.Name;
            }
            else if (classReference.Type != null)
            {
                name = classReference.Type.Name;
            }
        }

        public override IReadOnlyList<ReadOnlyGenericParameter> GenericParameters
        {
            get { return genericParameters; }
        }

        public override string Name
        {
            get { return name; }
        }
    }
}
