using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedStaticClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedAbstractClasses_NestedStaticClasses_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStaticClassWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStaticClassWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStaticClassWith1GenericParameterUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStaticClassWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStaticClassWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStaticClassWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStaticClassWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStaticClassWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStaticClassWith2GenericParametersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStaticClassWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterStructConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStaticClassWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithInternalNestedStaticClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithPrivateNestedStaticClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPrivateNestedStaticClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithProtectedNestedStaticClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedNestedStaticClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithProtectedInternalNestedStaticClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalNestedStaticClass));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithPublicNestedStaticClassUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPublicNestedStaticClass));
        }
    }
}
