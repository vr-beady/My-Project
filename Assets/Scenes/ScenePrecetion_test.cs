using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wave.Native;
using Wave.Essence.ScenePerception;


public class ScenePrecetion_test : MonoBehaviour
{
    public ScenePerceptionManager scenePerceptionManager = null;
    // Start is called before the first frame update
    void Start()
    {
        //�T�{scene perception�ण���
        if ((Interop.WVR_GetSupportedFeatures() & (ulong)WVR_SupportedFeature.WVR_SupportedFeature_ScenePerception) != 0)
        {
            WVR_Result result = scenePerceptionManager.StartScene();
            if (result == WVR_Result.WVR_Success)
            {
                result = scenePerceptionManager.StartScenePerception(WVR_ScenePerceptionTarget.WVR_ScenePerceptionTarget_2dPlane); //Start perceiving 2D planes

                if (result == WVR_Result.WVR_Success)
                {
                    /*
                    Examples of things to do here:
                    Scene Planes
                     Call scenePerceptionManager.GetScenePerceptionState() �d�ݷ�e�� WVR_ScenePerceptionState ���S�w WVR_ScenePerceptionTarget
                     Call scenePerceptionManager.StopScenePerception() to stop perceiving a specific WVR_ScenePerceptionTarget
                    
                    Spatial Anchors
                     1. scenePerceptionManager.GetSpatialAnchors() //�˯��{�������I
                     2. Using the retrieved handles, �� scenePerceptionManager.GetSpatialAnchorState() �o�����I����T
                    */
                }
            }
        }
        else
        {
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
