using CSharpDom.TestTarget.Structs.NestedSealedClasses.NestedDelegates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedSealedClasses_NestedDelegates_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedDelegateWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedDelegateWith1GenericParameterUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedDelegateWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedDelegateWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedDelegateWith2GenericParametersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedDelegateWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedDelegateWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedDelegateWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedDelegateWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedDelegateWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithInternalNestedDelegateUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedDelegateWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithNestedDelegateWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithNestedDelegateWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPrivateNestedDelegateUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPrivateNestedDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedNestedDelegateUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedNestedDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithProtectedInternalNestedDelegateUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithProtectedInternalNestedDelegate));
        }

        [TestMethod]
        public async Task TestStructWithNestedSealedClassWithPublicNestedDelegateUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedSealedClassWithPublicNestedDelegate));
        }
    }
}
