using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedStaticClasses_NestedAbstractClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedAbstractClassWith1AttributeUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedAbstractClassWith1GenericParameterUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedAbstractClassWith1ImplementedInterfaceUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedAbstractClassWith2GenericParametersUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedAbstractClassWith2ImplementedInterfacesUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedAbstractClassWithBaseClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithInternalNestedAbstractClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPrivateNestedAbstractClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithProtectedNestedAbstractClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithProtectedInternalNestedAbstractClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPublicNestedAbstractClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicNestedAbstractClass));
        }
    }
}
