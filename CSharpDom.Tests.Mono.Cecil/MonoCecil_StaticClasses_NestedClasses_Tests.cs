using CSharpDom.TestTarget.StaticClasses.NestedClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedClassWith1AttributeUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWith1GenericParameterUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWith2GenericParametersUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithBaseClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithInternalNestedClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithInternalNestedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithPrivateNestedClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPrivateNestedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithProtectedNestedClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithProtectedNestedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithProtectedInternalNestedClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithProtectedInternalNestedClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithPublicNestedClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithPublicNestedClass));
        }
    }
}
