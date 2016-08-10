using CSharpDom.TestTarget.SealedClasses.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_SealedClasses_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestSealedClassWithMethodWith1AttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterBaseSealedClassConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterBaseSealedClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterSealedClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterSealedClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterSealedClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterSealedClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterSealedClassConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterSealedClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithInternalMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNewMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestSealedClassWithOverrideMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestSealedClassWithPublicMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverrideMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestSealedClassWithStaticMethodUsingReflection()
        {
            TestSealedClassAsync(typeof(SealedClassWithStaticMethod));
        }
    }
}
