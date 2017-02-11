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
            TestSealedClass(typeof(SealedClassWithNestedClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithInternalMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithInternalMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewStaticMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithNewVirtualMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithOverrideMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPrivateMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithProtectedInternalMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithPublicMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithPublicMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithSealedOverrideMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithStaticMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithStaticMethod));
        }

        [TestMethod]
        public void TestSealedClassWithNestedClassWithVirtualMethodUsingReflection()
        {
            TestSealedClass(typeof(SealedClassWithNestedClassWithVirtualMethod));
        }
    }
}
