using CSharpDom.TestTarget.AbstractClasses.NestedStaticClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedStaticClasses_NestedAbstractClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWith1GenericParameterUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWith2GenericParametersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWithBaseClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithInternalNestedAbstractClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPrivateNestedAbstractClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithProtectedNestedAbstractClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithProtectedInternalNestedAbstractClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedStaticClassWithPublicNestedAbstractClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedStaticClassWithPublicNestedAbstractClass));
        }
    }
}
