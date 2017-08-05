using CSharpDom.TestTarget.Structs.NestedStructs.NestedSealedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStructs_NestedSealedClasses_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedSealedClassWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedSealedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedSealedClassWith1GenericParameterUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedSealedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedSealedClassWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedSealedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedSealedClassWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedSealedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedSealedClassWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedSealedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedSealedClassWith2GenericParametersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedSealedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedSealedClassWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedSealedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedSealedClassWithBaseClassUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedSealedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedSealedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedSealedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedSealedClassWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedSealedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedSealedClassWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedSealedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedSealedClassWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedSealedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedSealedClassWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedSealedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedSealedClassWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedSealedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithNestedSealedClassWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithNestedSealedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithInternalNestedSealedClassUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithInternalNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPrivateNestedSealedClassUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPrivateNestedSealedClass));
        }

        [TestMethod]
        public async Task TestStructWithNestedStructWithPublicNestedSealedClassUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStructWithPublicNestedSealedClass));
        }
    }
}
