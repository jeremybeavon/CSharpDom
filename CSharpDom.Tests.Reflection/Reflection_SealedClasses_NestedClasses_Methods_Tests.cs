using CSharpDom.TestTarget.SealedClasses.NestedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_NestedClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVirtualMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverrideMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNestedClassWithVirtualMethod));
        }
    }
}
