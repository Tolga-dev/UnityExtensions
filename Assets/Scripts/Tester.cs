using Extensions;
using UnityEngine ;


public class Tester : MonoBehaviour {

   [SerializeField] private AnimationClip clip;

   private void Start() {
      clip.AddAnimationEvent(1.3f, "OnEventTriggered");
      clip.AddAnimationEvent(1.5f, "OnFirstEvent");
      clip.AddAnimationEvent(3.0f, "OnSecondEvent");
   }

   private void OnEventTriggered() {
      Debug.Log("Event triggered!");
   }  

   private void OnFirstEvent() {
      Debug.Log("First event fired!");
   }

   private void OnSecondEvent() {
      Debug.Log("Second event fired!");
   }
}
