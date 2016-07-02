using CSharpDom.TestTarget.AbstractClasses.NestedStructs.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStructs_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMethodWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMethodWith1GenericParameterUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMethodWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMethodWith2GenericParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMethodWith2ReturnAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithInternalMethodUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPrivateMethodUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPublicMethodUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicMethod));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithStaticMethodUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithStaticMethod));
        }
    }
}
