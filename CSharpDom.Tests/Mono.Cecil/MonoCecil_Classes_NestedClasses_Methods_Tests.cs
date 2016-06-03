using CSharpDom.TestTarget.Classes.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Mono.Cecil
{
    [TestClass]
    public sealed class MonoCecil_Classes_NestedClasses_Methods_Tests : AbstractSolutionWithMonoCecilTests
    {
        [TestMethod]
        public async Task TestClassWithNestedClassWithMethodWith1AttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMethodWith1GenericParameterUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMethodWith1ReturnAttributeUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMethodWith2AttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWith2AttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMethodWith2GenericParametersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMethodWith2ReturnAttributesIn1AttributeGroupUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWith2ReturnAttributesIn1AttributeGroup));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMethodWithGenericParameterClassConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMethodWithGenericParameterStructConstraintUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithInternalMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewStaticMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithNewVirtualMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithOverrideMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMethodWithParametersWithAttributesUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithMethodWithParametersWithModifiersUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPrivateMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithProtectedInternalMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithPublicMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithSealedOverrideMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithStaticMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public async Task TestClassWithNestedClassWithVirtualMethodUsingMonoCecil()
        {
            await TestClassAsync(typeof(ClassWithNestedClassWithVirtualMethod));
        }
    }
}
