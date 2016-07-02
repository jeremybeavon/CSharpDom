using CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStructs_NestedClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedClassWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedClassWith1GenericParameterUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedClassWith2GenericParametersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedClassWithBaseClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithInternalNestedClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalNestedClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPrivateNestedClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateNestedClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPublicNestedClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicNestedClass));
        }
    }
}
