using UnityEngine;
using UnityEditor;
using System.Collections;

namespace UMotionEditor
{
	public static class AnimationCurveUtilityRecent
	{
		//********************************************************************************
		// Public Properties
		//********************************************************************************

        public static bool Implemented
        {
            get
            {
                #if UNITY_5_5_OR_NEWER
                return true;
                #else
                return false;
                #endif
            }
        }

        public static bool WeightedTangentsImplemented
        {
            get
            {
                #if UNITY_2018_1_OR_NEWER
                return true;
                #else
                return false;
                #endif
            }
        }

		//********************************************************************************
		// Private Properties
		//********************************************************************************
		
		//----------------------
		// Inspector
		//----------------------
		
		//----------------------
		// Internal
		//----------------------

		//********************************************************************************
		// Public Methods
		//********************************************************************************
		
        public static void SetKeyBroken(AnimationCurve curve, int index, bool broken)
        {
            #if UNITY_5_5_OR_NEWER
            AnimationUtility.SetKeyBroken(curve, index, broken);
            #endif
        }

        public static void SetKeyLeftTangentMode(AnimationCurve curve, int index, int tangentMode)
        {
            #if UNITY_5_5_OR_NEWER
            AnimationUtility.SetKeyLeftTangentMode(curve, index, (AnimationUtility.TangentMode)tangentMode);
            #endif
        }

        public static void SetKeyRightTangentMode(AnimationCurve curve, int index, int tangentMode)
        {
            #if UNITY_5_5_OR_NEWER
            AnimationUtility.SetKeyRightTangentMode(curve, index, (AnimationUtility.TangentMode)tangentMode);
            #endif
        }

        public static void SetKeyWeightedMode(ref Keyframe key, int weightedMode)
        {
            #if UNITY_2018_1_OR_NEWER
            key.weightedMode = (WeightedMode)weightedMode;
            #endif
        }

        public static int GetKeyWeightedMode(Keyframe key)
        {
            #if UNITY_2018_1_OR_NEWER
            return (int)key.weightedMode;
            #else
            return 0;
            #endif
        }

        public static void SetKeyLeftWeight(ref Keyframe key, float weight)
        {
            #if UNITY_2018_1_OR_NEWER
            key.inWeight = weight;
            #endif
        }

        public static float GetKeyLeftWeight(Keyframe key)
        {
            #if UNITY_2018_1_OR_NEWER
            return key.inWeight;
            #else
            return 1f / 3f;
            #endif
        }

        public static void SetKeyRightWeight(ref Keyframe key, float weight)
        {
            #if UNITY_2018_1_OR_NEWER
            key.outWeight = weight;
            #endif
        }        

        public static float GetKeyRightWeight(Keyframe key)
        {
            #if UNITY_2018_1_OR_NEWER
            return key.outWeight;
            #else
            return 1f / 3f;
            #endif
        }

        public static void SetLegacyTangentMode(ref Keyframe key, int tangentMode)
        {
            #if !UNITY_5_5_OR_NEWER
            key.tangentMode = tangentMode;
            #endif
        }

        public static int GetLegacyTangentMode(Keyframe key)
        {
            #if UNITY_5_5_OR_NEWER
            return 0;
            #else
            return key.tangentMode;
            #endif
        }

        //********************************************************************************
        // Private Methods
        //********************************************************************************
    }
}
