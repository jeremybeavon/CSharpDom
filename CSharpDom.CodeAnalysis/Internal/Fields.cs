using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CSharpDom.CodeAnalysis.Internal
{
    internal sealed class Fields<TField, TConstant, TType>
        where TType : ITypeWithCodeAnalysis
    {
        public Fields(
            TType declaringType,
            IFieldFactory<TField, TConstant, TType> fieldFactory)
        {
            List<TField> fields = new List<TField>();
            List<TConstant> constants = new List<TConstant>();
            foreach (FieldDefinition fieldDefinition in
                declaringType.TypeDefinition.Fields.Where(field => !field.IsDefined(declaringType.Assembly, typeof(CompilerGeneratedAttribute))))
            {
                if (fieldDefinition.HasConstant)
                {
                    constants.Add(fieldFactory.CreateConstant(declaringType, fieldDefinition));
                }
                else
                {
                    fields.Add(fieldFactory.CreateField(declaringType, fieldDefinition));
                }
            }

            FieldsWithCodeAnalysis = fields;
            ConstantsWithCodeAnalysis = constants;
        }

        public IReadOnlyCollection<TField> FieldsWithCodeAnalysis { get; private set; }

        public IReadOnlyCollection<TConstant> ConstantsWithCodeAnalysis { get; private set; }
    }
}
