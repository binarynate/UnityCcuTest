# Unity Conditional Compilation Utility Issue Repro

**UPDATE:** For the solution, see [this issue](https://github.com/Unity-Technologies/ConditionalCompilationUtility/issues/4) in the CCU repo.

This project demonstrates an issue where I'm unable to get the [Unity Conditional Compilation Utility](https://github.com/Unity-Technologies/ConditionalCompilationUtility) to work as expected. The [Test.cs](./Assets/Test.cs) file uses CCU to declare a `OCULUS_XR_INSTALLED` scripting symbol if the Oculus XR plugin is installed. However, the file demonstrates that `OCULUS_XR_INSTALLED` isn't defined, even though the Oculus XR plugin is installed in the project.

## Setting up the project

1. The Unity Conditional Compilation Utility is installed as a git submodule, so it must be initialized after cloneing the project:

```
git clone git@github.com:BinaryNate/UnityCcuTest.git
git submodule update --init
```

2. After that, you can open the project in Unity 2020.2.
