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
            TestSealedClass(typeof(SealedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithInternalMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNewMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNewMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNewStaticMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestSealedClassWithOverrideMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithPrivateMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestSealedClassWithProtectedInternalMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestSealedClassWithPublicMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestSealedClassWithSealedOverrideMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestSealedClassWithStaticMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithStaticMethod));
        }
    }
}
