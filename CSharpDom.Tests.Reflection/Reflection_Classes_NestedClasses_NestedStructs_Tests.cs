using CSharpDom.TestTarget.Classes.NestedClasses.NestedStructs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_NestedClasses_NestedStructs_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStructWith1AttributeUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStructWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStructWith1GenericParameterUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStructWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStructWith1ImplementedInterfaceUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStructWith1ImplementedInterface));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStructWith2AttributesIn1AttributeGroupUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStructWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStructWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStructWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStructWith2GenericParametersUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStructWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStructWith2ImplementedInterfacesUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStructWith2ImplementedInterfaces));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStructWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStructWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStructWithGenericParameterBaseClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStructWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStructWithGenericParameterClassConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStructWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStructWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStructWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStructWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStructWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStructWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNestedStructWithGenericParameterStructConstraintUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNestedStructWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalNestedStructUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateNestedStructUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateNestedStruct));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedNestedStructUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedNestedStruct));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalNestedStructUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalNestedStruct));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicNestedStructUsingReflection()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicNestedStruct));
        }
    }
}
