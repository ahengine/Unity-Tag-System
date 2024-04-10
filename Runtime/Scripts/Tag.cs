using UnityEngine;

namespace UTag
{
   public class Tag : MonoBehaviour
   {
      [field: SerializeField] public Tagger Tagger { protected set; get; }
   }
}