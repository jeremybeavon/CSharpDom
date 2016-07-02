using CSharpDom.TestTarget.StaticClasses.NestedAbstractClasses.NestedAbstractClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_StaticClasses_NestedAbstractClasses_NestedAbstractClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNestedAbstractClassWith1AttributeUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedAbstractClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNestedAbstractClassWith1GenericParameterUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedAbstractClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNestedAbstractClassWith1ImplementedInterfaceUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedAbstractClassWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedAbstractClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNestedAbstractClassWith2GenericParametersUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedAbstractClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNestedAbstractClassWith2ImplementedInterfacesUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedAbstractClassWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNestedAbstractClassWithBaseClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedAbstractClassWithBaseClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithNestedAbstractClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithInternalNestedAbstractClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPrivateNestedAbstractClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPrivateNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedNestedAbstractClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithProtectedInternalNestedAbstractClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithProtectedInternalNestedAbstractClass));
        }

        [TestMethod]
        public async Task TestStaticClassWithNestedAbstractClassWithPublicNestedAbstractClassUsingReflection()
        {
            await TestStaticClassAsync(typeof(StaticClassWithNestedAbstractClassWithPublicNestedAbstractClass));
        }
    }
}
