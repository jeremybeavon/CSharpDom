using CSharpDom.TestTarget.StaticClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.CodeAnalysis
{
    [TestClass]
    public sealed class CodeAnalysis_StaticClasses_Methods_Tests : AbstractSolutionWithCodeAnalysisTests
    {
        [TestMethod]
        public async Task TestStaticClassWithMethodWith1AttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithMethodWith1GenericParameterUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithMethodWith1ReturnAttributeUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithMethodWith2AttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithMethodWith2AttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithMethodWith2GenericParametersUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithMethodWithGenericParameterBaseClassConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithMethodWithGenericParameterClassConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithMethodWithGenericParameterGenericParameterConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithMethodWithGenericParameterInterfaceConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithMethodWithGenericParameterStructConstraintUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithInternalMethodUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestStaticClassWithMethodWithParametersWithAttributesUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestStaticClassWithMethodWithParametersWithModifiersUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivateMethodUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicMethodUsingCodeAnalysis()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicMethod));
        }
    }
}
