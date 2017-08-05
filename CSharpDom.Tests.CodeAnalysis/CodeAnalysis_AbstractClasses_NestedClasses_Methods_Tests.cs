using CSharpDom.TestTarget.AbstractClasses.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_AbstractClasses_NestedClasses_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMethodWith1AttributeUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMethodWith1ReturnAttributeUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithInternalMethodUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewMethodUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewStaticMethodUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithNewVirtualMethodUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithOverrideMethodUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPrivateMethodUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedMethodUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithProtectedInternalMethodUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithPublicMethodUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithSealedOverrideMethodUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithStaticMethodUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedClassWithVirtualMethodUsingCodeAnalysis()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedClassWithVirtualMethod));
        }
    }
}
