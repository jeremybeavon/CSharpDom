using Mono.Cecil;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class Fields<TField, TConstant, TType>
        where TType : ITypeWithMonoCecil
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

            FieldsWithMonoCecil = fields;
            ConstantsWithMonoCecil = constants;
        }

        public IReadOnlyCollection<TField> FieldsWithMonoCecil { get; private set; }

        public IReadOnlyCollection<TConstant> ConstantsWithMonoCecil { get; private set; }
    }
}
