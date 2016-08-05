using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDom.Mono.Cecil.Internal
{
    internal sealed class Attributes
    {
        public Attributes(AssemblyWithMonoCecil assembly, ICustomAttributeProvider member, params Type[] excludedTypes)
        {
            string[] excludedTypeReferences = excludedTypes.Select(type => type.FullName).ToArray();
            AttributesWithMonoCecil = member.CustomAttributes
                .Where(attribute => !excludedTypeReferences.Contains(attribute.Constructor.DeclaringType.FullName))
                .Select(attribute => new AttributeWithMonoCecil(assembly, attribute))
                .ToList();
        }
        
        public IReadOnlyCollection<AttributeWithMonoCecil> AttributesWithMonoCecil { get; private set; }
    }
}
