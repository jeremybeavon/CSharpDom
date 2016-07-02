using CSharpDom.TestTarget.SealedClasses.NestedStructs.Methods.ExplicitInterfaceMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_SealedClasses_NestedStructs_Methods_ExplicitInterfaceMethods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithExplicitInterfaceMethodWith1AttributeUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitInterfaceMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithExplicitInterfaceMethodWith1GenericParameterUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitInterfaceMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitInterfaceMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithExplicitInterfaceMethodWith2GenericParametersUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitInterfaceMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithExplicitInterfaceWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitInterfaceWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestSealedClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithModifiersUsingMonoCecil()
        {
            await TestSealedClassAsync(typeof(SealedClassWithNestedStructWithExplicitInterfaceMethodWithParametersWithModifiers));
        }
    }
}
