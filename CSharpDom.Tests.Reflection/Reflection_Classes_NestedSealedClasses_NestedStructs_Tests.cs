using CSharpDom.TestTarget.Classes.NestedSealedClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedSealedClasses_NestedStructs_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStructWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStructWith1GenericParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStructWith1ImplementedInterfaceUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStructWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStructWith2GenericParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStructWith2ImplementedInterfacesUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStructWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStructWithGenericParameterClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStructWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithNestedStructWithGenericParameterStructConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithInternalNestedStructUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPrivateNestedStructUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedNestedStructUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithProtectedInternalNestedStructUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestClassWithNestedSealedClassWithPublicNestedStructUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedSealedClassWithPublicNestedStruct));
        }
    }
}
