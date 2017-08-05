using CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_NestedStructs_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStructWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStructWith1GenericParameterUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStructWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStructWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStructWith2GenericParametersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStructWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStructWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStructWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStructWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedStructWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalNestedStructUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivateNestedStructUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedNestedStructUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalNestedStructUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicNestedStructUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicNestedStruct));
        }
    }
}
