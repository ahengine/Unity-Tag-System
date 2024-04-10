using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Tagger enemyTag;

    private void OnTriggerEnter(Collider other)
    {
        var tag = other.GetComponent<Tag>();

        if (tag && enemyTag.Compare(tag.Tagger))
            print("Enemy Detected");
    }
}
