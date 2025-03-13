using System;
using UnityEngine;

namespace Extensions
{
   public static class AnimationEventsExtension {

      public static void AddAnimationEvent(this AnimationClip clip, float time, string functionName) {
         var clipDuration = clip.length;

         if (time < 0f) {
            Debug.LogError($"Event time must be greater than or equal to 0.0 seconds.");
            return;
         }

         if (time > clipDuration) {
            Debug.LogError($"Event time must be less than or equal to the clip's duration: {clipDuration} seconds.");
            return;
         }

         AnimationEvent animationEvent = new AnimationEvent {
            time = time,
            functionName = functionName
         };

         clip.AddEvent(animationEvent);
      }
   }
}
