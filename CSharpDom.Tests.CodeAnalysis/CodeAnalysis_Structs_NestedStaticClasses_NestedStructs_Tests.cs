using CSharpDom.TestTarget.Structs.NestedStaticClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedStaticClasses_NestedStructs_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStructWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStructWith1GenericParameterUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStructWith1ImplementedInterfaceUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStructWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStructWith2GenericParametersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStructWith2ImplementedInterfacesUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStructWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStructWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStructWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithNestedStructWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithInternalNestedStructUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPrivateNestedStructUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithProtectedNestedStructUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithProtectedInternalNestedStructUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestStructWithNestedStaticClassWithPublicNestedStructUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedStaticClassWithPublicNestedStruct));
        }
    }
}
