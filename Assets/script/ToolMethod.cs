using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolMethod
{

public static float 获取与目标的夹角(Vector3 t1,Transform t2)
    {
        Vector3 localVect = t1 - t2.position;
        localVect.y = 0;
        Vector3 forwardVect = t2.forward;
        forwardVect.y = 0;
        return Vector3.Angle(localVect, forwardVect);
    }
    
}
   