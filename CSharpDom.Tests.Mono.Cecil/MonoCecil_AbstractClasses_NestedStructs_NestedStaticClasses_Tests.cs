using CSharpDom.TestTarget.AbstractClasses.NestedStructs.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_AbstractClasses_NestedStructs_NestedStaticClasses_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStaticClassWith1AttributeUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStaticClassWith1GenericParameterUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStaticClassWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStaticClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStaticClassWith2GenericParametersUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStaticClassWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithNestedStaticClassWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithInternalNestedStaticClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPrivateNestedStaticClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStructWithPublicNestedStaticClassUsingMonoCecil()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStructWithPublicNestedStaticClass));
        }
    }
}
