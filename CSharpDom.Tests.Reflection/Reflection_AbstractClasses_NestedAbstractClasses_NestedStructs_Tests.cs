using CSharpDom.TestTarget.AbstractClasses.NestedAbstractClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_AbstractClasses_NestedAbstractClasses_NestedStructs_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStructWith1AttributeUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStructWith1GenericParameterUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStructWith1ImplementedInterfaceUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStructWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStructWith2GenericParametersUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStructWith2ImplementedInterfacesUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterStructConstraintUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithInternalNestedStructUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithPrivateNestedStructUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithProtectedNestedStructUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithProtectedInternalNestedStructUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestAbstractClassWithNestedAbstractClassWithPublicNestedStructUsingReflection()
        {
            await TestAbstractClassAsync(typeof(AbstractClassWithNestedAbstractClassWithPublicNestedStruct));
        }
    }
}
