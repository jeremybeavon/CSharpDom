using CSharpDom.TestTarget.Classes.Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace CSharpDom.Tests.Reflection
{
    [TestClass]
    public sealed class Reflection_Classes_Methods_Tests : AbstractSolutionWithReflectionTests
    {
        [TestMethod]
        public void TestClassWithMethodWith1AttributeUsingReflection()
        {
            TestClass(typeof(ClassWithMethodWith1Attribute));
        }

        [TestMethod]
        public void TestClassWithMethodWith1GenericParameterUsingReflection()
        {
            TestClass(typeof(ClassWithMethodWith1GenericParameter));
        }

        [TestMethod]
        public void TestClassWithMethodWith1ReturnAttributeUsingReflection()
        {
            TestClass(typeof(ClassWithMethodWith1ReturnAttribute));
        }

        [TestMethod]
        public void TestClassWithMethodWith2AttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithMethodWith2AttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithMethodWith2GenericParametersUsingReflection()
        {
            TestClass(typeof(ClassWithMethodWith2GenericParameters));
        }

        [TestMethod]
        public void TestClassWithMethodWith2ReturnAttributesIn2AttributeGroupsUsingReflection()
        {
            TestClass(typeof(ClassWithMethodWith2ReturnAttributesIn2AttributeGroups));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterBaseClassConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithMethodWithGenericParameterBaseClassConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClass(typeof(ClassWithMethodWithGenericParameterClassAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraintsUsingReflection()
        {
            TestClass(typeof(ClassWithMethodWithGenericParameterClassAndInterfaceAndEmptyConstructorConstraints));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterClassConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithMethodWithGenericParameterClassConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterEmptyConstructorConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithMethodWithGenericParameterEmptyConstructorConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterGenericParameterConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithMethodWithGenericParameterGenericParameterConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterInterfaceConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithMethodWithGenericParameterInterfaceConstraint));
        }

        [TestMethod]
        public void TestClassWithMethodWithGenericParameterStructConstraintUsingReflection()
        {
            TestClass(typeof(ClassWithMethodWithGenericParameterStructConstraint));
        }

        [TestMethod]
        public void TestClassWithInternalMethodUsingReflection()
        {
            TestClass(typeof(ClassWithInternalMethod));
        }

        [TestMethod]
        public void TestClassWithNewMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNewMethod));
        }

        [TestMethod]
        public void TestClassWithNewStaticMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNewStaticMethod));
        }

        [TestMethod]
        public void TestClassWithNewVirtualMethodUsingReflection()
        {
            TestClass(typeof(ClassWithNewVirtualMethod));
        }

        [TestMethod]
        public void TestClassWithOverrideMethodUsingReflection()
        {
            TestClass(typeof(ClassWithOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithMethodWithParametersWithAttributesUsingReflection()
        {
            TestClass(typeof(ClassWithMethodWithParametersWithAttributes));
        }

        [TestMethod]
        public void TestClassWithMethodWithParametersWithModifiersUsingReflection()
        {
            TestClass(typeof(ClassWithMethodWithParametersWithModifiers));
        }

        [TestMethod]
        public void TestClassWithPrivateMethodUsingReflection()
        {
            TestClass(typeof(ClassWithPrivateMethod));
        }

        [TestMethod]
        public void TestClassWithProtectedMethodUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedMethod));
        }

        [TestMethod]
        public void TestClassWithProtectedInternalMethodUsingReflection()
        {
            TestClass(typeof(ClassWithProtectedInternalMethod));
        }

        [TestMethod]
        public void TestClassWithPublicMethodUsingReflection()
        {
            TestClass(typeof(ClassWithPublicMethod));
        }

        [TestMethod]
        public void TestClassWithSealedOverrideMethodUsingReflection()
        {
            TestClass(typeof(ClassWithSealedOverrideMethod));
        }

        [TestMethod]
        public void TestClassWithStaticMethodUsingReflection()
        {
            TestClass(typeof(ClassWithStaticMethod));
        }

        [TestMethod]
        public void TestClassWithVirtualMethodUsingReflection()
        {
            TestClass(typeof(ClassWithVirtualMethod));
        }
    }
}
