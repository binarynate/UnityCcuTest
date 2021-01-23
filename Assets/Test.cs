using System;
using System.Diagnostics;
using ConditionalCompilation;

[assembly: OptionalDependencyAttribute("Unity.XR.Oculus", "OCULUS_XR_INSTALLED")]

[Conditional("UNITY_CCU")]
public class OptionalDependencyAttribute : Attribute {
    public string dependentClass;
    public string define;

    public OptionalDependencyAttribute(string dependentClass, string define) {
        this.dependentClass = dependentClass;
        this.define = define;
    }
}

[UnityEditor.InitializeOnLoad]
class Test {

    static Test() {

        #if OCULUS_XR_INSTALLED
            UnityEngine.Debug.Log(">>> Oculus XR is installed");
        #else
            UnityEngine.Debug.Log(">>> Oculus XR is NOT installed");
        #endif
    }
}
