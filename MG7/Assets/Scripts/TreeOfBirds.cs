using UnityEngine;

public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private GameObject[] _birds;
    [SerializeField] private Transform _player;
    [SerializeField] private float _interactionDistance = 5f;

    private void Update()
    {
        foreach (GameObject bird in _birds)
        {
            if (Vector3.Distance(transform.position, _player.position) <= _interactionDistance)
            {
                bird.SetActive(true);
            }
        }
    }
}