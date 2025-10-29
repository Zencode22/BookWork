using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int CurrentAge = 30;
    public int AddedAge = 1;

    void Start()
    {
        ComputeAge();
    }


    /// <summary>
    /// Computes a modified age by adding two varibles together
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }
}