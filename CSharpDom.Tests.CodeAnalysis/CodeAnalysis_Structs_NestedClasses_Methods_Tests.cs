using CSharpDom.TestTarget.Structs.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_Structs_NestedClasses_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWith1AttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWith1ReturnAttributeUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithInternalMethodUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewMethodUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewStaticMethodUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithNewVirtualMethodUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithOverrideMethodUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPrivateMethodUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedMethodUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithProtectedInternalMethodUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithPublicMethodUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithSealedOverrideMethodUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithStaticMethodUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public async Task TestStructWithNestedClassWithVirtualMethodUsingCodeAnalysis()
        {
            await TestStructAsync(typeof(StructWithNestedClassWithVirtualMethod));
        }
    }
}
