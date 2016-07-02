using CSharpDom.TestTarget.StaticClasses.NestedStaticClasses.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_StaticClasses_NestedStaticClasses_NestedStaticClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWith1AttributeUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWith1GenericParameterUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWith2GenericParametersUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithInternalNestedStaticClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPrivateNestedStaticClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithProtectedNestedStaticClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithProtectedNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithProtectedInternalNestedStaticClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithProtectedInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedStaticClassWithPublicNestedStaticClassUsingMonoCecil()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedStaticClassWithPublicNestedStaticClass));
        }
    }
}
